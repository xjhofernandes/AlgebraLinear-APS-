using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento e maprovaçã onão pode ir para finalziado direto");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
