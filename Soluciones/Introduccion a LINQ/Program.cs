using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                2,3,4,6,-5,8,9,-11,-15,-11,-1
            };

            var nPositivos = numbers.Where(x => x > 0).ToList();
            foreach (var i in nPositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
