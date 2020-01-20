using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ItemDaNota
    {
        public String Nome { get; set; }
        public Double Valor { get; set; }

        public ItemDaNota(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
