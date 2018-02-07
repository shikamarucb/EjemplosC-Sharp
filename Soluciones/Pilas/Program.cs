using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            for(int i = 0; i < 10; i++)
            {
                //agrega numeros a la pila
                numeros.Push(i);
            }

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++)
            {
                //elimina numeros de la pila
                numeros.Pop();
            }

            Console.WriteLine();

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
