using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    //Definicion del contrato del web service
    [ServiceContract]
    public interface IWCFEjemplo
    {

        //Operaciones o funciones del contrato
        [OperationContract]
        Persona ObtenerPersonas(int id);
    }

    //Datos del contrato
    [DataContract]
    public class Persona : BaseMensaje
    {
        //Parte de los datos del contrato
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }
    }

    [DataContract]
    public class BaseMensaje
    {
        [DataMember]
        public string Error { get; set; }
    }
}
