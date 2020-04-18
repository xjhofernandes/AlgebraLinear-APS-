using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AluraWebApp.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;

        public PedidoRepository(ApplicationContext contexto, 
            IHttpContextAccessor contextAcessor) : base(contexto)
        {
            this.contextAccessor = contextAcessor;
        }

        private int? GetPedidoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet.Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .SingleOrDefault(p => p.Id == pedidoId);

            if (pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);

                contexto.SaveChanges();

                SetPedidoId(pedido.Id);
            }

            return pedido;
        }

        public void AddItem(string codigo)
        {
            var produto = contexto
                .Set<Produto>()
                .SingleOrDefault(p => p.Codigo == codigo);

            if (produto == null)
            {
                throw new ArgumentException("Produto não encontrado");
            }

            var pedido = GetPedido();

            var itemPedido = contexto.Set<ItemPedido>()
                .Where(i => i.Produto.Codigo == codigo 
                            && i.Pedido.Id == pedido.Id)
                .SingleOrDefault();

            if (itemPedido == null)
            {
                itemPedido = new ItemPedido(pedido, produto,1, produto.Preco);
                contexto.Set<ItemPedido>().Add(itemPedido);

                contexto.SaveChanges();
            }

        }
    }
}
