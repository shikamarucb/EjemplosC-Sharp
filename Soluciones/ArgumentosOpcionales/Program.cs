using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumentos
{
    public class Program1
    {
        static void Main(string[] args)
        {
            //Revisar el video si se presentan problemas
            //https://www.youtube.com/watch?v=hhmdsGStDGQ&list=PL0kIvpOlieSN-PDnM2rHXdb3kib9njJaQ&index=36

            suma(5);
            suma(5,2);

            Console.WriteLine("\nFin del programa");
            Console.Read();
        }

        //los parametros opcionales SIEMPRE van al final
        public static void suma(int a, int b = 30){
            Console.WriteLine(a + b);
        }
    }
}
