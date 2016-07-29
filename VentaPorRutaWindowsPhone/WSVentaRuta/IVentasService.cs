using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WSVentaRuta.DataModel;

namespace WSVentaRuta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IVentasService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IVentasService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Login/{Usuario,Pass}",
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]

        InicioSesion Login(string Usuario, string Pass);
    }
}
