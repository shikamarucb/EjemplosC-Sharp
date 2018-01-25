using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.ElevadoALa(2,2));
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }

    //Por Convencion usar un nombre similar
    public static class IntegerExtensionMethods {

        public static double ElevadoALa(this int valor, int n)
        {
            return Math.Pow(valor, n);
        }

        public static double ElevadoALa(this int valor, int n, int x)
        {
            return Math.Pow(valor, n+x);
        }
    }
}
