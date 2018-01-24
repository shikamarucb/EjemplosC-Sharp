using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vector(new List<int>() { 1, 123, 5, 9 });

            //accediendo al elemento mediante indexador
            v[0] = 20;

            //obteniendo elemento mediante indexador
            Console.WriteLine("El valor del elemento con indice 1: " + v[1]);

            Console.WriteLine("Elementos elevados al cuadrado");
            foreach (var n in v.valores) {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nFin del programa");
            Console.Read();
            
        }
    }

    class Vector {

        private List<int> _valores;

        //INDEXADOR
        //El indexador me permite acceder a un atributo privado mediante llaves-> []
        //
        //public + tipo de elemento de la lista(int,si la lista fuera string entonces se pondria
        //string) + this[int n] ("n es el valor del indice")
        public int this[int n] {

            //retorna el n-esimo valor de la lista
            get { return _valores[n]; }
            
            //se accede al n-esimo valor de la lista y se le cambia su valor
            //"value" es el valor que se le asigna, ejemplo: en el main el objeto se llama v
            //entonces si hago v[0]=123; "value=123"
            set { _valores[n] = value; }
        }

        public List<int> valores {
            //se puede redefinir el metodo get una vez usado prop
            get {
                List<int> NuevaLista = new List<int>();
                foreach (var n in _valores) {
                    
                    NuevaLista.Add((int)Math.Pow(n,2));
                }
                return NuevaLista;
            }
        }

        public Vector(List<int> valores) {
            _valores = valores;
        }

    }
}
