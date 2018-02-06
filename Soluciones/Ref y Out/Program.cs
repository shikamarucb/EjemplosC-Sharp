using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_y_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref y out nos sirven para que un tipo de valor exponga un comportamiento
            //parecido al de los tipos de referencia, es decir pasar un tipo de valor como si fuera un tipo de referencia

            var persona = new Persona() { Nombre = "Andres" };
            int Edad = 9;

            Console.WriteLine("Valores antes");
            Console.WriteLine("edad: " + Edad);
            Console.WriteLine("nombre: " + persona.Nombre);

            //La diferencia entre out y ref es que out obligatoriamente tiene que asignarle un valor en el metodo,
            //en cambio ref no es obligatorio. Si se comenta la linea de codigo donde se asgina un nuevo valor en el
            //metodo "CambiarInt2" se mostrará un error
            CambiarInt(ref Edad, 23);
            CambiarInt2(out Edad, 23);

            CambiarString(persona, "Felipe");

            Console.WriteLine("\nValores despues");
            Console.WriteLine("edad: " + Edad);
            Console.WriteLine("nombre: " + persona.Nombre);

            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }

        static void CambiarString(Persona persona, String valor)
        {
            persona.Nombre = valor;
        }

        static void CambiarInt(ref int valor, int valor2)
        {
            //valor = valor2;
        }

        static void CambiarInt2(out int valor, int valor2)
        {
            valor = valor2;
        }
    }


    class Persona
    {
        public string Nombre { get; set; }
    }
}
