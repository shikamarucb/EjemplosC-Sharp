using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WCFEjemplo : IWCFEjemplo
    {
        
        public Persona ObtenerPersonas(int id)
        {
            if (id == 1)
                return new Persona()
                {
                    Nombre = "Jaime",
                    Edad = 23
                };
            else
                return new Persona()
                {
                    Error = "El Id no corresponde con ninguna persona"
                };
        }
    }
}
