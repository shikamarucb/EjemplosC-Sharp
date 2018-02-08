using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los predicados son un tipo de delegado que reciben un generico y devuelven un bool
            Predicate<Animal> predicado = Mayor;
            Animal a = new Animal()
            {
                Nombre = "Perro",
                Edad = 6
            };

            Console.WriteLine(predicado(a));
            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }

        static bool Mayor(Animal a)
        {
            return a.Edad > 5;
        }

        public class Animal
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }
    }
}
