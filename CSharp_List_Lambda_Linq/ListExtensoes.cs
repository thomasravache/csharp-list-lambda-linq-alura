using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_Lambda_Linq
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> lista, params int[] items)
        {
            foreach(int item in items)
            {
                lista.Add(item);
            }
        }
    }
}
