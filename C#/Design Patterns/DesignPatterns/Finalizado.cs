using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento finalizados não recebem desconto extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um estado finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception(" Não é possível finalizar um estado já finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um estado já finalizado.");
        }
    }
}
