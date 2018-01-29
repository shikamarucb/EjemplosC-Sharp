using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            perro1.nombre = "juan";
            perro1.nPatas = 4;

            CienPies cienpies1 = new CienPies();
            cienpies1.nombre = "carlos";
            cienpies1.nPatas = 100;

            List<Animal> animales = new List<Animal>() { perro1, cienpies1 };

            foreach (var animal in animales)
            {
                Console.WriteLine(animal.nombre + " tiene {0} patas", animal.nPatas);
            }

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }

    class Animal {
        public string nombre { get; set; }
        public int nPatas { get; set; }
    }

    //Las clases perro y cienpies herendan atributos y propiedades de la clase animal
    class Perro:Animal {

    }

    class CienPies:Animal {

    }
}
