using Argumentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentosOpcionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1.suma(4);
            new ClassLibrary3.Class1().metodo(3);

            Console.WriteLine("\nFin del programa");
            Console.Read();
        }

        
    }
}
