using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsEj
{
    class Program
    {
        enum estados {
            pendiente=1,
            procesando=2,
            completado=3,
            eliminado=4
        };

        static void Main(string[] args)
        {
            //los enums evitan la manipulacion de estados fantasma, si deseo
            //cambiar el valor de algun estado, lo hago en el enum no mas

            int estado_de_la_operacion = 2;

            if (estado_de_la_operacion == (int)estados.pendiente)
                Console.WriteLine("Esta pendiente la informacion");
            else if (estado_de_la_operacion == (int)estados.procesando)
                Console.WriteLine("Se esta procesando la informacion");
            else if (estado_de_la_operacion == (int)estados.completado)
                Console.WriteLine("Se ha procesado la informacion");
            else if (estado_de_la_operacion == (int)estados.eliminado)
                Console.WriteLine("Se ha eliminado la informacion");

            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }
    }
}
