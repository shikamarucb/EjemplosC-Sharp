using Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los 3 heredan de la clase animal
            var perro1 = new Perro();
            var can1 = new Can();
            var dog1 = new Dog();

            var animal1 = new Animal();
            var animal2 = new Animal();
            var animal3 = new Animal();

            //Los objetos invocan el metodo desde su clase actual(Perro, Can, Dog)
            Console.WriteLine("perro1 haciendo ruido como perro: " + perro1.HacerRuido());
            Console.WriteLine("can1 haciendo ruido como can: " + can1.HacerRuido());
            Console.WriteLine("dog1 haciendo ruido como dog: " + dog1.HacerRuido());


            animal1 = perro1;
            animal2 = can1;
            animal3 = dog1;

            //Los objetos invocan el metodo desde su clase Base(Animal)
            Console.WriteLine("\nperro1 haciendo ruido como animal: " + animal1.HacerRuido());
            Console.WriteLine("can1 haciendo ruido como animal: " + animal2.HacerRuido());
            Console.WriteLine("dog1 haciendo ruido como animal: " + animal3.HacerRuido());


            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}


namespace Animales
{
    public class Animal
    {
        //solo esta clase puede acceder a este atributo
        private string reino = "Animalia";

        //solo esta clase y las clases derivadas(Perro, Can, Dog) pueden acceder a este atributo.
        //La clase Program NO PUEDE acceder a este atributo porque no es un tipo de animal
        protected string genes = "genes de animal";

        //Este atributo puede ser accedido desde todas las clases 
        public int nOjos = 2;

        //Este atributo puede ser accedido desde todas las clases que se encuentran en el
        //assembly es decir todas las clases que se encuentran en el proyecto Polimorfismo
        //(es decir, se convierte en PUBLIC dentro de este proyecto)
        internal bool pelaje = true;


        //ENCAPSULAMIENTO
        public string nombre { get; set; }
        public int nPatas { get; set; }

        public virtual string HacerRuido() {
            return "Estoy haciendo ruido";
        }

    }

    //Las clases perro y cienpies herendan atributos y propiedades de la clase animal
    class Perro : Animal
    {
        //Sobreescribe el metodo cuando vuelve a la clase base
        public override string HacerRuido() {

            //Accede al atributo genes al ser una clase derivada
            genes = "genes de perro";
            return "Woof Woof!" + " y tengo " + genes;
        }

    }

    class Can : Animal
    {
        //No sobreescribe el metodo cuando vuelve a la clase base(Animal)
        //pero lo usa cuando se usa desde un objeto Can
        public new string HacerRuido() {
            return "guau guau";
        }
    }

    class Dog : Animal {
        //Este metodo tiene un new implicito
        public string HacerRuido() {
            return "WOOF GUAU";
        }
    }

}
