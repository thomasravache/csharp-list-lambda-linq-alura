using ByteBank.Modelos;
using CSharp_List_Lambda_Linq.Comparadores;
using CSharp_List_Lambda_Linq.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_List_Lambda_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestaSort();
            //TestarSortComClasse();
        }

        static void TestarSortComClasse()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 9999),
                new ContaCorrente(343, 1),
                new ContaCorrente(344, 18950)
            };

            //contas.Sort(); Utilizando IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta =>
            {
                if (conta == null)
                {
                    return int.MaxValue;
                }

                return conta.Numero;
            });

            foreach(var conta in contasOrdenadas)
            {
                if (conta == null)
                {
                    Console.WriteLine("Conta nula");
                } 
                else
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Guilherme",
                "Luana",
                "Ana",
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(6);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
