using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //el nullable se usa para poder asignar "null" a los tipos por valor
            //ya que "null" solo es posible asignarlo a los tipos por referencia
            Nullable<int> a = null;
            int? b = null;

            if (!a.HasValue)
            {
                b = 2;

                //para acceder al valor se utiliza el atributo value
                metodo(b.Value);
            }

            Console.WriteLine("\nFin del programa");
            Console.Read();
        }

        /// <summary>
        /// Calcula el cuadrado de un numero
        /// </summary>
        /// <param name="n"></param>
        static void metodo(int n) {
            Console.WriteLine(n + " elevado a la 2: " + Math.Pow(n,2));
        }
    }
}
