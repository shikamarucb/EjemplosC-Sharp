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

            var personas = new List<Persona>()
            {
                new Persona(){Edad=12},
                new Persona(){Edad=16},
                new Persona(){Edad=11},
                new Persona(){Edad=114},
            };

            var nPositivos = numbers.Where(x => x > 0).ToList();

            var nPositivosPares = numbers.Where(x => x > 0 && x % 2 == 0).ToList();

            var eMayores = personas.Where(x => x.Edad > 13);

            foreach (var i in eMayores)
            {
                Console.WriteLine(i.Edad);
            }
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }

        class Persona
        {
            public int Edad { get; set; }
        }
    }
}
