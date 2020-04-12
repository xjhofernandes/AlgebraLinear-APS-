using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraWebApp.Repositories;
using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AluraWebApp.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;


        public PedidoController(IProdutoRepository produtoRepository,
            IPedidoRepository pedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
                pedidoRepository.AddItem(codigo);

            var pedido = pedidoRepository.GetPedido();

            return View(pedido.Itens);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }
    }
}
