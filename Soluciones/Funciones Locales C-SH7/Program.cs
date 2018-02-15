using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Locales_C_SH7
{
    class Program
    {
        static void Main(string[] args)
        {
            void Funcion1()
            {
                Console.WriteLine("Hola desde Funcion1");

                int Funcion2(int a, int b)
                {
                    return a + b;
                }

                Console.WriteLine("Hola desde Funcion 2, 5+7:"+Funcion2(5,7));
            }

            Funcion1();

            Funcion3();

            void Funcion3()
            {
                Console.WriteLine("Hola desde funcion 3");
            }

            int Multiplicar(int x, int y) => x * y;

            Console.WriteLine("Hola desde Expresion Lambda: "+Multiplicar(5,7));

            Console.Read();
        }
    }
}
