using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> persona = new Dictionary<int, string>();
            persona.Add(1, "Andres");
            persona.Add(2, "Felipe");
            persona.Add(3, "Camacho");
            persona.Add(4, "Barragan");

            Console.WriteLine(persona[1]);

            if (persona.ContainsKey(5))
            {
                Console.WriteLine(persona[5]);
            }

            persona.Remove(2);

            foreach (var keys in persona.Keys)
            {
                Console.WriteLine(keys);
            }

            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }
    }
}
