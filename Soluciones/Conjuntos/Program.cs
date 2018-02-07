using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Operaciones con conjuntos

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para ver los resultados use break points

            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();
            Random a=new Random(2);

            for (int i = 0; i < 10; i++)
            {
                conjunto1.Add(a.Next(0, 5));
                conjunto2.Add(a.Next(0, 5));
            }

            //Operacion de union
            HashSet<int> union_c1_c2 = new HashSet<int>(conjunto1);
            union_c1_c2.UnionWith(conjunto2);

            //Operacion de interseccion
            HashSet<int> interseccion_c1_c2 = new HashSet<int>(conjunto1);
            interseccion_c1_c2.UnionWith(conjunto2);

            //Operacion diferencia
            HashSet<int> diferencia_c1_c2 = new HashSet<int>(conjunto1);
            diferencia_c1_c2.ExceptWith(conjunto2);

            //Operacion diferencia simetrica
            HashSet<int> diferenciaSimetrica_c1_c2 = new HashSet<int>(conjunto1);
            diferenciaSimetrica_c1_c2.ExceptWith(conjunto2);

            List<int> numeros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(a.Next(0,5));
            }

            numeros = new HashSet<int>(numeros).ToList();

        }
    }
}
