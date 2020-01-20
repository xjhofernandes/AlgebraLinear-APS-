using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }

        //Template Method
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento)) return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
