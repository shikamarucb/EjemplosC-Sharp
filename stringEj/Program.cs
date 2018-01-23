using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringEj
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Felipe Camacho Barragan";
            string cadena2 = "    Felipe Camacho Barragan   ";

            //length: longitud de la cadena
            Console.WriteLine("Length: " + cadena.Length);

            //substring:sustrae una subcadena de la cadena
            Console.WriteLine("Substring: " + cadena.Substring(7, 7));

            //startswith: pregunta si la cadena empieza con el parametro dado
            Console.WriteLine("startswith: " + cadena.StartsWith("Felipe"));

            //endswidth: pregunta si la cadena termina con el parametro dado
            Console.WriteLine("endswith: " + cadena.EndsWith("Barragan"));

            //contains: pregunta si la cadena contiene el parametro dado
            Console.WriteLine("contains: " + cadena.Contains("Camacho"));

            //indexof: Retorna el indice del parametro dado
            //si no existe retorna -1
            Console.WriteLine("indexof: " + cadena.IndexOf("Barragan"));

            //tolower: convierte la cadena en minuscula
            Console.WriteLine("tolower: " + cadena.ToLower());

            //toupper: convierte la cadena en mayuscula
            Console.WriteLine("toupper: " + cadena.ToUpper());

            //trim: elimina los espacios en blanco al comienzo y final de la cadena
            Console.WriteLine("trim: " + cadena2.Trim());

            //format: construye una cadena de acuerdo con los parametros que se le pasan
            //entre los corchetes
            string cadena3 = "Felicidades {0} en tu grado numero {1}";
            Console.WriteLine("format: " + string.Format(cadena3, cadena,2));

            //replace: reemplaza una subcadena por otra
            string cadena4 = "Felicidades @nombre en tu grado numero @numero";
            cadena4 = cadena4.Replace("@nombre", cadena);
            cadena4 = cadena4.Replace("@numero", "2");
            Console.WriteLine("replace: " + cadena4);

            //isnullorwhitespace: pregunta si la cadena tiene espacios o es nula
            string cadena5 = "  ";
            string cadena6 = null;
            Console.WriteLine("isnullorwhitespace: " + string.IsNullOrWhiteSpace(cadena5));
            Console.WriteLine("isnullorwhitespace: " + string.IsNullOrWhiteSpace(cadena6));


            Console.WriteLine("\n"+ "Fin del programa");
            Console.Read();

        }
    }
}
