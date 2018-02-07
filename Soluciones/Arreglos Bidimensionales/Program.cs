using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            //a.GetLength(1) obtiene el numero de elementos de la dimension de indice 1

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = i + j;
                }
            }
        }
    }
}
