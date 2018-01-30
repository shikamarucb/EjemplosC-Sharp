using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Object_y_Operador_is
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todos los tipos heredan de la clase Object(Todas las clases, 
            //estructuras, enumeraciones y delegados.)

            //object es lo mismo que Object
            //Int32 es lo mismo que int
            //Int64 es lo mismo que long

            Object o = "Hola mundo";
            o = true;
            o = 5;
            o = DateTime.Today;
            Console.WriteLine(((DateTime)o).Day);

            //operador "is" Se utiliza para comparar dos objetos referencia variables. 
            if (!(o is Boolean)) {
                metodo(o);
            }

            Console.WriteLine("\nFin del programa");
            Console.Read();
        }

        static void metodo(Object obj) {
            Console.WriteLine(obj.ToString());
        }
    }
}
