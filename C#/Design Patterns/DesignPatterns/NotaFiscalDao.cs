using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("salvando no BD");
        }
    }
}
