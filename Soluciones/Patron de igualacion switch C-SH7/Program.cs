using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_igualacion_switch_C_SH7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo figura1 = new Rectangulo() { alto = 1, ancho = 2 };
            Rectangulo figura2 = new Rectangulo() { alto = 1, ancho = 1 };
            Triangulo figura3 = new Triangulo();
            Cicunferencia figura4 = new Cicunferencia();

            Resultado(figura1);
            Resultado(figura2);
            Resultado(figura3);
            Resultado(figura4);

            Console.Read();

        }

        static void Resultado(Figura figura)
        {
            switch (figura)
            {
                case Triangulo t:
                    Console.WriteLine("Es un triangulo y tiene {0} lados jaja",t.NumLados);
                    break;
                case Rectangulo r when r.alto == r.ancho:
                    Console.WriteLine("Es un cuadrado de perimetro: {0}",r.ancho*4);
                    break;
                case Rectangulo r2:
                    Console.WriteLine("Es un Rectangulo de perimetro {0}",r2.ancho*2+r2.alto*2);
                    break;
                default:
                    Console.WriteLine("Debe ser una circunferencia");
                    break;
            }
        }
    }

    class Figura
    {

    }

    class Cicunferencia : Figura
    {
    }
    class Rectangulo : Figura
    {
        public int ancho { get; set; }
        public int alto { get; set; }
    }

    class Triangulo : Figura
    {
        private int nLados=3;

        public int NumLados
        {
            get { return nLados; }
        }

    }
}

