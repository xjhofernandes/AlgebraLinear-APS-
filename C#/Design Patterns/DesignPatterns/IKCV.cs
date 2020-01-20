using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) 
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReasNo(orcamento);

        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReasNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
