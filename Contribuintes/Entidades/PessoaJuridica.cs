using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entidades
{
    internal class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, double rendaanual, int numeroTrabalhadores) : base(nome, rendaanual)
        {
            NumeroTrabalhadores = numeroTrabalhadores;
        }

        public int NumeroTrabalhadores { get; set; }

        public override double imposto()
        {
            if(NumeroTrabalhadores <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }

    }
}
