using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_vs_Const
{
    class Program
    {
        //readonly y const sirven para definir valores que no varían. La diferencia radica en que readonly puede ser definido en tiempo de ejecución, 
        //mientras que const debe ser definido en tiempo de compilación.


        const double PI = 3.14;
        static readonly double PI_2 = RepositorioValores.PI;

        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(PI_2);
            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }
    }

    class RepositorioValores {
        public static double PI = 3.14159;
    }
}
