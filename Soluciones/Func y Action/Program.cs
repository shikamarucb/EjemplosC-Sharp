using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_y_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func y Action son delegados por defecto, Func se usa cuando la funcion que yo le asigne al delegado
            //retorna un valor y Action se usa cuando la funcion asignada al delegado no retorna valor

            Func<int, string> delegadoFunc = cadena;

            Action<int> delegadoAction = imprimir;

            Console.WriteLine(delegadoFunc(57));
            delegadoAction(58);

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }

        static string cadena(int a)
        {
            return a.ToString();
        }

        static void imprimir(int a)
        {
            Console.WriteLine(a);
        }
    }
}
