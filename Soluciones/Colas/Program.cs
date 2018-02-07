using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>();

            for(int i = 0; i < 10; i++)
            {
                //agrega elementos a la cola
                cola.Enqueue(i);
            }
            foreach (var i in cola)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                //Quita elementos de la cola
                Console.WriteLine(cola.Dequeue());
            }

            Console.WriteLine();

            foreach (var i in cola)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFin del Programa");
            Console.Read();


        }
    }
}
