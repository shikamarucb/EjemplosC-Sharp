using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Encapsular();

            //No se llama el metodo como comunmente se hace, se le asigna el valor directamente
            obj1.edad = 23;

            //No se llama el metodo como comunmente se hace, se le asigna el valor directamente
            obj1.obtenerNombre = "Andres";

            Console.WriteLine("Accediendo a la propiedad nombre: " + obj1.obtenerNombre);
        }
    }

    class Encapsular {

        public int edad { get; set; }
        private string nombre;

        public string obtenerNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
