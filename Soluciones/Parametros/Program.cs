using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero de parametros variable
            Metodo(5,5,5,5);

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }

        static void Metodo(params int[] valores)
        {
            foreach (var n in valores)
            {
                Console.WriteLine(n);
            }
            
        }
    }

    
}
