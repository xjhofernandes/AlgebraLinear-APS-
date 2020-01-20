using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envio do email");
        }
    }
}
