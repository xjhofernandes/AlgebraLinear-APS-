using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;

namespace AluraWebApp.Repositories
{
    public interface ICadastroRepository
    {
    }

    public class CadastroRepository : BaseRepository<ItemPedido>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
