using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //Chain of Responsibility - Cadeira de responsabilidades
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
