using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSVentaRuta.DataModel
{
    public class InicioSesion
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

    }
}