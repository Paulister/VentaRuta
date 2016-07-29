using VentaPorRutaWindowsPhone.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaPorRutaWindowsPhone.ViewModel
{
    class UsuariosViewModel :  Observable
    {
        private SQLiteConnection db; 
        public ObservableCollection<DataModel.Usuarios> Usuarios { get; private set; }

        public bool DatosCargados { get; set; }

        public UsuariosViewModel(string connectionString)
        {
            db = new SQLiteConnection(connectionString, true);
            db.CreateTable<DataModel.Usuarios>();

            this.Usuarios = new ObservableCollection<DataModel.Usuarios>();
            DatosCargados = false;
        }
    }
}
