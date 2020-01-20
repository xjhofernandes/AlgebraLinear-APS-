using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Programa2
    {
        static void Main(string[] args)
        {
            //Orcamento reforma = new Orcamento(500);
            //Console.WriteLine(reforma.Valor);

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();
            //try
            //{
            //reforma.AplicaDescontoExtra();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //Fluent Interface ~ Um método atrás do outro (Method Chaining)
            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("Radix")
            .ComCnpj("28.456.789/0041-12")
            .comItem(new ItemDaNota("Apple tv", 5000))
            .NaDataAtual()
            .ComObservacoes("Uma coisa qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSMS());
            criador.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf);
        }
}
}
