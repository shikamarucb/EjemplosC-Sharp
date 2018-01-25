using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(new List<int>() { 1, 2 });
            var v2 = new Vector(new List<int>() { 5, 2 });
            var v3 = new Vector(new List<int>() { -15, -12 });

            var v = v1.Sumar(v2);
            Console.WriteLine("La suma de v1 + v2 = " + v.valor[0] + " y " + v.valor[1]);

            v = v1 + v3 + v2;
            Console.WriteLine("La suma de v1 + v3 + v2 = " + v.valor[0] + " y " + v.valor[1]);

            Console.WriteLine("\nFin del programa");
            Console.Read();

        }
    }

    class Vector {
        List<int> valores; 

        public Vector(List<int> valores) {
            this.valores = valores;
        }

        //public static "valor de retorno" "operador a sobrecargar" ("parametros")
        public static Vector operator +(Vector vector1, Vector vector2) {
            return vector1.Sumar(vector2);
        }

        public Vector Sumar(Vector v) {

            Vector NuevoVector = new Vector(new List<int> { 0,0 });

            for (int i = 0; i < v.valores.Count; i++)
            {
                NuevoVector.valores[i] = this.valores[i] + v.valores[i];
            }

            return NuevoVector;
        }

        public List<int> valor {
            get {
                return valores;
            }
        }
    }
}
