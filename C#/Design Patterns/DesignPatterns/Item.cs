using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Item
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
