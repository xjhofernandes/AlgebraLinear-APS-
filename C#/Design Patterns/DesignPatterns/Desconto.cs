using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
