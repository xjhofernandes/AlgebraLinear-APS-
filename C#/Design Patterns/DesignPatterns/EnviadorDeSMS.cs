using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class EnviadorDeSMS : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando por SMSM");
        }
    }
}
