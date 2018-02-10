using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leyendo_App_Config
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensaje = ConfigurationManager.AppSettings["mensaje"];
            Console.WriteLine(mensaje);
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
