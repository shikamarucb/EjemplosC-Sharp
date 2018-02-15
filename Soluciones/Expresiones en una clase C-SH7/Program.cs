using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_en_una_clase_C_SH7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            c.MyProperty = 3;

            Console.Read();
        }
    }

    class Cuadrado
    {
        public Cuadrado()
        {

        }

        public Cuadrado(int dimension) => AsignarDimension(dimension);

        private void AsignarDimension(int dimension)
        {
            Altura = dimension;
        }

        public int Altura { get; set; }

        public int funcion()
        {
            return 1;
        }

        public int MyProperty {
            get=>funcion();
            set =>AsignarDimension(value);
        }

        ~Cuadrado()=> Destruir();

        private void Destruir()
        {

        }
    }
}
