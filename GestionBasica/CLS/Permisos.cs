using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Permisos
    {
        String _IDPermiso;
        String _IDRol;
        String _IDOpcion;
        String _Motrar;

        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }

        public string IDOpcion
        {
            get
            {
                return _IDOpcion;
            }

            set
            {
                _IDOpcion = value;
            }
        }

        public string Motrar
        {
            get
            {
                return _Motrar;
            }

            set
            {
                _Motrar = value;
            }
        }

        public string IDPermiso
        {
            get
            {
                return _IDPermiso;
            }

            set
            {
                _IDPermiso = value;
            }
        }

        public Boolean Conceder()
        {
            Boolean Concedido = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Permisos";
            Sentencia += " SET Mostrar=1";
            Sentencia += " WHERE IDPermiso=" + _IDPermiso + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia) > 0)
                {
                    Concedido = true;
                }
            }
            catch { }
            return Concedido;
        }
        public Boolean Revocar()
        {
            Boolean Revocado = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Permisos";
            Sentencia += " SET Mostrar=0";
            Sentencia += " WHERE IDPermiso=" + _IDPermiso + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia) > 0)
                {
                    Revocado = true;
                }
            }
            catch { }
            return Revocado;
        }
    }
}
