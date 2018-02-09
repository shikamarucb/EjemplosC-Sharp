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
                3,3,28,6,-5,8,9,-11,-15,-11,-1
            };

            var personas = new List<Persona>()
            {
                new Persona(){Edad=12, Nombre="Andres"},
                new Persona(){Edad=16,Nombre="Felipe"},
                new Persona(){Edad=11,Nombre="Camacho"},
                new Persona(){Edad=114,Nombre="Berragan"},
                new Persona(){Edad=114,Nombre="Barragan"},
            };

            //where simple
            var nPositivos = numbers.Where(x => x > 0).ToList();

            //Multiples condiciones
            var nPositivosPares = numbers.Where(x => x > 0 && x % 2 == 0).ToList();

            //where con objeto
            var eMayores = personas.Where(x => x.Edad > 13);

            //where con indice
            var indicePar = numbers.Where((x, indice) => indice % 2 == 0).ToList();

            //OrderBy OrderByDescending y ThenBy
            #region OrderBy ThenBy
            //Ordena en orden ascendente y alfabeticamente
            var alfabetico = personas.OrderBy(x => x.Nombre).ToList();

            //Ordena en orden descendiente y alfabeticamente
            var alfabeticoD = personas.OrderBy(x => x.Nombre).ToList();

            //Ordena en orden primeramente numerico y despues alfabetico
            var alfaNumerico = personas.OrderBy(x => x.Edad).ThenBy(x => x.Nombre).ToList();
            #endregion OrderBy ThenBy

            //Reversar una lista
            #region Reverse
            var reverseNumbers = new List<int>(numbers);
            var reverseNumbers2 = new List<int>(numbers);

            reverseNumbers.Reverse();

            //Reversar lista con indice de comienzo y numero de elementos a partir del indice
            reverseNumbers2.Reverse(1,7);
            #endregion Reverse

            //Primer elemento de una lista o elemento por defecto
            #region First FirstOrDefault

            //First hace lo mismo que FirstOrDefault, la diferencia es que si se ejecuta el metodo First
            //en una lista vacia va a lanzar una excepcion y si se hace con FirstOrDefault va a devolver el valor
            //por defecto

            var primero = numbers.First();
            var primeroLambda = numbers.FirstOrDefault(x => x % 2 == 0);

            #endregion First FirstOrDefault

            
            Console.WriteLine("FirstOrDefault: "+ primeroLambda);
            

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }

        class Persona
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }
    }
}
