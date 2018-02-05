using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro();
            Animal animal;
            perro.Nombre = "Benji";
            Console.WriteLine(perro.Nombre);
            perro.ObtenerEdad();
            animal = perro;
            Console.WriteLine(animal.ObtenerEdad());
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }

    //La clase abstracta no se puede instanciar
    abstract class Animal
    {
        private int Edad=15;
        public string Nombre { get; set; }
        public virtual int ObtenerEdad()
        {
            return Edad;
        }
    }

    class Perro:Animal
    {
        public new void ObtenerEdad()
        {
            Console.WriteLine("Upss!");
        }
    }
}
