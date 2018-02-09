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

            //where simple
            var nPositivos = numbers.Where(x => x > 0).ToList();

            //Multiples condiciones
            var nPositivosPares = numbers.Where(x => x > 0 && x % 2 == 0).ToList();

            //where con objeto
            var eMayores = personas.Where(x => x.Edad > 13);

            //where con indice
            var indicePar = numbers.Where((x, indice) => indice % 2 == 0).ToList();

            Console.WriteLine("Numeros  de indice par");

            foreach (var i in indicePar)
            {
                Console.WriteLine(i);
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
