using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion_de_Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perro puede cambiarse por cualquier clase que implemente la interfaz animal
            var animal = new Perro();
            var ruido = new Ruido(animal);
            ruido.HaciendoRuido("Alberto");

            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }
    }

    //La clase ruido elimina las dependencias de clase, yo puedo hacer que cualquier animal
    //ejecute el metodo HacerRuido simplemente cambiando la instancia de la variable animal(var animal)
    //en el metodo Main
    class Ruido {

        private Animal _animal;

        public Ruido(Animal animal)
        {
            _animal = animal;
        }

        public void HaciendoRuido(string Name) {
            Console.WriteLine(_animal.HacerRuido(Name));
        }
    }
}

namespace Interfaces
{
    interface Animal
    {
        string HacerRuido(string Name);
    }

    class Tigre : Animal
    {
        public string HacerRuido(string Name)
        {
            return Name + " : Grrrr!!";
        }
    }

    class Perro : Animal
    {
        public string HacerRuido(string Name)
        {
            return Name + " : Woof Woof!!";
        }
    }
}
