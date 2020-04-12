using CasaDoCodigo.Models;

namespace AluraWebApp.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}