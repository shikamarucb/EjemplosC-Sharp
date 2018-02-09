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
                new Persona(){Edad=10, Nombre="Andres",salario=123},
                new Persona(){Edad=16,Nombre="Felipe",salario=66},
                new Persona(){Edad=11,Nombre="Camacho",salario=876},
                new Persona(){Edad=114,Nombre="Berragan",salario=99},
                new Persona(){Edad=114,Nombre="Barragan",salario=68},
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

            //uso de select con proyeccion
            #region select y proyeccion

            //x => new{Edad = x.Edad, Nombre = x.Nombre} esta expresion es una proyeccion de un objeto tipo Persona
            //en un objeto Anonimo

            var selectPersona = personas.Where(x => x.Edad == 114).OrderBy(x => x.Edad).ThenBy(x => x.Nombre).
                Select(x => new { Edad = x.Edad, Nombre = x.Nombre }).ToList();

            #endregion select y proyeccion

            //Take y skip
            //se salta 3 numeros de la lista de numeros y toma los 4 siguientes
            var newList = numbers.Skip(3).Take(4).ToList();

            //TakeWhile y SkipWhile

            //Toma los elementos mientras se cumple la condicion, cuando se deja de cumplir, no toma mas elementos
            var newList2 = numbers.TakeWhile(x => x >= -5).ToList();
            //Escapa los elementos mientras se cumple la condicion, cuando se deja de cumplir, empieza a añadirlos
            var newList3 = numbers.SkipWhile(x => x > 0).ToList();

            #region GroupBy

            //Agrupa la lista de enteros en dos: los numeros pares cuyo residuo es 0 y los impares cuyo residuo es 1
            var newList4 = numbers.GroupBy(x => Math.Abs(x % 2));


            //Agrupa la lista de personas segun la cadena de retorno
            var newList5 = personas.GroupBy(x =>
            {
                if (x.Edad <= 10)
                    return "Menores de 11";
                else if (x.Edad > 10 && x.Edad <= 20)
                    return "Mayores de 10 y menores de 21";
                else
                    return "Mayores de 20";

            }).ToList();

            #endregion GroupBy

            #region All y Any
            //All y Any

            //Devuelve un valor booleano(true) si TODOS los elementos de la lista son pares
            var bool1 = numbers.All(x => x % 2 == 0);

            //Devuelve un valor booleano(true) si ALGUNO de los elementos de la lista es par
            var bool2 = numbers.Any(x => x % 2 == 0);
            #endregion All y Any

            //Sum //Suma de los salarios de las personas
            var valor1 = personas.Sum(x => x.salario);

            //Max Min Average
            var salarioMenor = personas.Min(x => x.salario);
            var salarioMayor = personas.Max(x => x.salario);
            var salarioPromedio = personas.Average(x => x.salario);

            


            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }

        class Persona
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
            public decimal salario { get; set; }
        }
    }
}
