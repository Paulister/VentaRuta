﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSVentaRuta.DataModel;

namespace WSVentaRuta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "VentasService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione VentasService.svc o VentasService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class VentasService : IVentasService
    {
        public Boolean Login(string Usuario, string Pass)
        {
            using (VentasModelDataContext db = new VentasModelDataContext())
            {
                
                    Usuarios us = db.Usuarios.FirstOrDefault(x => x.Usuario == Usuario);
               if (us.Contraseña == Pass)
                    {
                        return true;
                    }
               else
                    {
                        return false;
                    }
            }


        }
    }
}
