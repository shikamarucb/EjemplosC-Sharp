using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Coleccion<int> coleccion = new Coleccion<int>();
            Coleccion<string> coleccion2 = new Coleccion<string>();

            Coleccion2<int,string> coleccion3 = new Coleccion2<int,string>();
            Coleccion2<string,double> coleccion4 = new Coleccion2<string,double>();

            coleccion.Agregar(3);
            coleccion2.Agregar("Hola mundo");

            Console.WriteLine("\nFin del  Programa");
            Console.Read();
        }
    }

    class Coleccion<T>
    {
        public List<T> MiLista { get; set; }

        public Coleccion()
        {
            MiLista = new List<T>();
        }

        public void Agregar(T valor)
        {
            MiLista.Add(valor);
        }
    }

    class Coleccion2<T,M>
    {
        public List<T> MiLista { get; set; }

        public Coleccion2()
        {
            MiLista = new List<T>();
        }

        public void Agregar(T valor)
        {
            MiLista.Add(valor);
        }

        public void Agregar(M valor2)
        {
            //
        }
    }
}
