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
