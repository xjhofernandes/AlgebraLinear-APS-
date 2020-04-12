using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace AluraWebApp.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}