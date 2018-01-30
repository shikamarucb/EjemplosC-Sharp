using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Anonimos_y_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos anonimos se usan para evitar instanciar una clase y debe usarse 
            //solo en metodos locales

            //El tipo dynamic permite que las operaciones en las que se produce omitan 
            //la comprobación de tipo en tiempo de compilación. 

            var objeto1 = new { Nombre = "Andres", Apellido = "Camacho", Edad = 23 };
            var objeto2 = new { Nombre = "Andrea", Apellido = "Camacho", Edad = 27 };

            //Una lista dynamic demanda MUCHAS MAS capacidad de calculo, ya que el
            //compilador hace mas procesos para agregar los objetos anonimos
            List<dynamic> lista = new List<dynamic>();

            lista.Add(objeto1);
            lista.Add(objeto2);

            foreach (dynamic objeto in lista)
            {
                //Intellisense no funciona porque no reconoce los tipos anonimos
                Console.WriteLine("{0} {1} tiene {2} años", objeto.Nombre, objeto.Apellido,
                    objeto.Edad);
            }

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
