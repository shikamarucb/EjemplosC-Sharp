using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animales;

namespace Polimorfismo
{
    class GatoSphynx : Animal
    {
        public GatoSphynx()
        {
            //El gato de raza Sphynx no tiene pelaje
            pelaje = false;
        }
    }
}
