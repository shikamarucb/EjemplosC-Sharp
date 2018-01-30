using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Tigre tigre = new Tigre();
            Perro perro = new Perro();
            ejecutar(tigre, "Alberto");
            ejecutar(perro, "Bengie");

            Console.WriteLine("\n Fin del Programa");
            Console.Read();
        }

        //Puedo recibir cualquier clase que herede de la interfaz Animal(Tigre, Perro)
        static void ejecutar(Animal animal, string Name) {
            Console.WriteLine(animal.HacerRuido(Name));
        }
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

namespace Interfaces {

    //La interfaz solo puede definir metodos
    //La interfaz es publica asi como los metodos definidos son publicos
    interface Animal {
        string HacerRuido(string Name);
    }
}
