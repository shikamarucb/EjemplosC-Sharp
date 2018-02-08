using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, double> operacion = (x, y) =>
                {
                    x = (int)Math.Pow(x, 2);
                    y = (int)Math.Pow(y, 2);
                    return x + y;
                };

            Console.WriteLine(operacion(2,3));
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
