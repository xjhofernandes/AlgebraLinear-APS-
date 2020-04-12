using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using AluraWebApp.Repositories;
using CasaDoCodigo.Models;
using Microsoft.Extensions.WebEncoders.Testing;
using Newtonsoft.Json;

namespace AluraWebApp
{
    public partial class DataService : IDataService
    {
        private IProdutoRepository produtoRepository;
        private ApplicationContext contexto { get; set; }

        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();

            var livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");

            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }

}