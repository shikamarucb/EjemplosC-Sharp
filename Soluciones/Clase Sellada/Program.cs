using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Sellada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se puede instanciar una clase sellada pero no se puede heredar desde una clase sellada
            Animal animal = new Animal();

        }
    }

    sealed class Animal
    {

    }

    //class Perro : Animal
    //{

    //}
}
