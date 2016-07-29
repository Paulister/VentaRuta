using VentaPorRutaWindowsPhone.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace VentaPorRutaWindowsPhone.DataModel
{
    [Table("Usuarios")]
    public class Usuarios : Observable
    {
        private int _Id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                NotifyPropertyChaged("Id");
            }
        }

        private string _Usuario;
        [PrimaryKey, AutoIncrement]
        public string Usuario
        {
            get { return Usuario; }
            set
            {
                _Usuario = value;
                NotifyPropertyChaged("Usuario");
            }
        }

        private string _Contraseña;
        [PrimaryKey, AutoIncrement]
        public string Contraseña
        {
            get { return Contraseña; }
            set
            {
                _Contraseña = value;
                NotifyPropertyChaged("Contraseña");
            }
        }
    }
}
