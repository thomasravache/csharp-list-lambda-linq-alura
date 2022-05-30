using CSharp_List_Lambda_Linq.Extensoes;
using System;
using System.Collections.Generic;


namespace CSharp_List_Lambda_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            var idades2 = new List<int>();

            idades2.Add(2);
            idades2.Add(3);

            foreach (int idade in idades2)
            {
                Console.WriteLine($"Idades2 {idade}");
            }

            idades.Add(1);
            idades.Add(5);
            idades.Add(6);

            //idades.Remove(1);

            //ListExtensoes.AdicionarVarios<int>(idades, 1, 2, 3, 4);

            idades.AdicionarVarios(9, 9, 9, 9);

            for(int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
