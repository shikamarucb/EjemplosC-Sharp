using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restricciones_en_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Animal>();

            Generico_struct<int>(5);
            Generico_class<Animal>();

            var perro = Generico_constructor<Perro>();

            Console.WriteLine("Tipo de la variable perro: " + perro.GetType());
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
        static void Generico_struct<T>(T valor) where T : struct
        {

        }

        static void Generico_class<T>()where T : class, new()
        {

        }

        static void Generico_interface<T>(T implementacion) where T : IEnumerable<T>
        {
            foreach(T item in implementacion)
            {

            }
        }

        static C Generico_constructor<C>()where C : new()
        {
            return new C();
        }

        static void Generico_Herencia<A>(A animal)where A : Animal
        {

        }

        
    }

    class Animal
    {

    }

    class Perro : Animal
    {


    }

    class Gato : Animal
    {

    }
}
