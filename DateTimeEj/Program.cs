using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fecha con hora
            DateTime fechaHora = new DateTime(2017, 10, 30, 23, 12, 15);
            Console.WriteLine(fechaHora);

            //Fecha
            DateTime fecha = new DateTime(1980,1,1);
            Console.WriteLine(fecha);

            //Impresion con formato
            Console.WriteLine(fecha.ToString("dd / yyyy / MMMM"));
            Console.WriteLine(fechaHora.ToString("dd / yyyy / MMMM /hh:mm:ss"));

            //Añadir dias
            fecha = fecha.AddDays(30);
            Console.WriteLine("Nueva fecha: " + fecha);

            //Dia de la semana
            Console.WriteLine(fecha.DayOfWeek);

            //Restar fechas
            Console.WriteLine(fechaHora.Subtract(fecha).Days);

            Console.Read();
        }
    }
}
