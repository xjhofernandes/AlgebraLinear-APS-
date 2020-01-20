using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class CriadorDeNotaFiscal //NotaFiscalBuilder ~ Na prática
    {
        //BUILDER
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private double valorTotal;
        private double impostos;
        private List<AcaoAposGerarNota> TodasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal,
                impostos, todosItens, Observacoes);
            //Padrão de projeto Observer ~ Desaclopar o código 
            foreach (AcaoAposGerarNota acao in TodasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            TodasAcoesASeremExecutadas.Add(novaAcao);
        }

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(String obs)
        {
            Observacoes = obs;
            return this;
        }

        public CriadorDeNotaFiscal NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }

        public CriadorDeNotaFiscal ComCnpj(String cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal comItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

    }
}
