using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = FactoriaAnimales<int, string>(2);
            
            Console.WriteLine("Animal es tipo: " + animal.GetType());
            Console.WriteLine("\nFin del Programa");
            Console.Read();
        }


        static Animal<T,M> FactoriaAnimales<T,M>(int seleccion)
        {
            if (seleccion == 1)
                return new Perro<T, M>();
            if (seleccion == 2)
                return new Gato<T, M>();

            //Por defecto
            return new Gato<T, M>();
        }

    }


    interface Animal<T, M>
    {
        void Agregar();
    }

    public class Perro<T, M> : Animal<T, M>
    {
        public void Agregar()
        {
            throw new NotImplementedException();
        }
    }

    public class Gato<T, M> : Animal<T, M>
    {
        public void Agregar()
        {
            throw new NotImplementedException();
        }
    }
}
