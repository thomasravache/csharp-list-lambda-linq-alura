using ByteBank.Modelos;
using CSharp_List_Lambda_Linq.Extensoes;
using System;
using System.Collections.Generic;


namespace CSharp_List_Lambda_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestaSort();
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

            contas.Sort();

            foreach(var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
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
