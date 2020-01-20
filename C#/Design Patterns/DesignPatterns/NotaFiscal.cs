using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao, 
            double valorBruto, double impostos, IList<ItemDaNota> itens, 
            String obs)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = obs;
        }

        public override string ToString()
        {
            return @"Razão social: " + RazaoSocial + "\nCnpj: " + Cnpj
                + "\nData de Emissão: " + DataDeEmissao + "\nValor Bruto: " + ValorBruto
                + "\nImpostos: " + Impostos + "\nItens: " + Itens[0] + "\nObservação: " + Observacoes;
        }

    }
}
