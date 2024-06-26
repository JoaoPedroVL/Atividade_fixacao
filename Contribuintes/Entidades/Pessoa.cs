﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entidades
{
    abstract internal class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa(string nome, double rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        public abstract double imposto();
    }
}
