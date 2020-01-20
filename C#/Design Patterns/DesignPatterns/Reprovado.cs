using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento reprovados não recbem desconto extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um  já reprovado.");
        }
    }
}
