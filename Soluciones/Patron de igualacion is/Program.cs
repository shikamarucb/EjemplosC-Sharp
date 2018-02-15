using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_igualacion_is
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura figura1 = new Poligono();
            Figura figura2 = new Cicunferencia();

            //Antes de C# 7
            var fg = figura1 as Poligono;

            if(fg != null)
            {
                fg.nLados = 5;
            }
            //Despues de C# 7
            if(figura1 is Poligono fg2)
            {
                fg2.nLados = 8;
            }
        }
    }

    class Figura
    {

    }

    class Cicunferencia:Figura
    {

    }
    class Poligono:Figura
    {
        public int nLados { get; set; }
    }
}
