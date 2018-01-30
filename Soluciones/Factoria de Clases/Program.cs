using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoria_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Bengie";
            var animal = FactoriaDeClases.Factoria(nombre);
            var ruido = new Ruido(animal);
            ruido.HaciendoRuido(nombre);

            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }
    }

    //Esta clase se encarga de una nueva instancia dependiendo del parametro que le envie
    static class FactoriaDeClases {

        public static Animal Factoria(string Name) {

            if (Name == "Alberto") {

                return new Tigre();

            } else if (Name == "Bengie") {

                return new Perro();

            }
            throw new ApplicationException();
        }
    }


    class Ruido
    {

        private Animal _animal;

        public Ruido(Animal animal)
        {
            _animal = animal;
        }

        public void HaciendoRuido(string Name)
        {
            Console.WriteLine(_animal.HacerRuido(Name));
        }
    }
}


