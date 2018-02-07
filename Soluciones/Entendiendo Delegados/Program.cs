using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entendiendo_Delegados
{
    class Program
    {
        delegate void Delegado(int a);
        
        static void Main(string[] args)
        {
            Delegado dl = new Delegado(funcion1);
            funcion2(dl, 12);
            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }

        static void funcion1(int a)
        {
            Console.WriteLine(a+1);
        }

        static void funcion2(Delegado dl1, int valor)
        {
            Console.WriteLine("Antes de ejecutar funcion");
            dl1(valor);
            Console.WriteLine("Despues de ejecutar funcion");
        }
    }
}
