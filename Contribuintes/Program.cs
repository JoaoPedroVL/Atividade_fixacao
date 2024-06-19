using Contribuintes.Entidades;
using System;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();

            Console.Write("Qual o numero de pagantes? ");
            int pagante = int.Parse(Console.ReadLine());

            for(int i = 1; i <= pagante; i++)
            {
                Console.WriteLine($"Pagante #{i} dados: ");
                Console.Write("Pessoa fisica ou CNPJ ? (F/C)");
                char ch = char.Parse(Console.ReadLine().ToUpper());

                if( ch == 'F')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());

                    Console.Write("Uso na medicina: ");
                    double medicina = double.Parse(Console.ReadLine());

                    listaPessoa.Add(new PessoaFisica(rendaAnual, medicina, nome));
                    

                }
                else if (ch == 'C')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());

                    Console.Write("Numero de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    listaPessoa.Add(new PessoaJuridica(nome, rendaAnual, funcionarios));

                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXA DOS PAGATES: ");

            foreach (Pessoa obj in listaPessoa)
            {
                //double tax = obj.imposto();
                Console.WriteLine($"{obj.Nome} : ${obj.imposto().ToString("F2")} ");
                sum += obj.imposto();
            }
            Console.WriteLine($"Soma total: {sum}");


        }
    }
}