using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Metodos_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona() { Nombre="Andres"};
            var empresa = new Empresa() { Nombre = "Sys SA",Nit=814355466 };
            Console.WriteLine(Serializar<Persona>(persona));
            Console.WriteLine("\n" + Serializar<Empresa>(empresa));
            Console.WriteLine("\nFin del Programa");
            Console.Read();

        }

        public static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));
            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
    }

    public class Empresa
    {
        public string Nombre { get; set; }
        public int Nit { get; set; }
    }
}
