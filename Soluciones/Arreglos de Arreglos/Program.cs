using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_de_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[4];
            array[0][0] = 5;
            array[0][1] = 3;
            array[0][2] = 4;
            array[0][3] = 3;
            array[1] = new int[]
            {
                1,2,5,7,8,23,1
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var join = string.Join(",", array[i]);
                Console.WriteLine(join);
            }

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
