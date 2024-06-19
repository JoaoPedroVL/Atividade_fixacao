using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entidades
{
    internal class PessoaFisica : Pessoa
    {
        public PessoaFisica(double rendaanual,double gassaude,string nome) : base(nome, rendaanual)
        {
            GasSaude = gassaude;
        }
        public double GasSaude { get; set; }

        public override double imposto()
        {
            if(RendaAnual < 20000.0)
            {
                return (RendaAnual * 0.15) - (GasSaude * 0.5);
            }
            else
            {
                 return RendaAnual * 0.25 - GasSaude * 0.5;
            }
        }
        



    }
}
