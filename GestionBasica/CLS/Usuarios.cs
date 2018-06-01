using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Usuarios
    {
        String _IDUsuario;
        String _Usuario;
        String _Credencial;
        String _IDEmpleado;
        String _IDRol;

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Credencial
        {
            get
            {
                return _Credencial;
            }

            set
            {
                _Credencial = value;
            }
        }

        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
            }
        }

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


        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Usuarios(Usuario, Credencial, IDEmpleado, IDRol) VALUES(";
            Sentencia += "'" + _Usuario + "',SHA1('" + _Credencial + "')," + _IDEmpleado + "," + _IDRol;
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch
            { }
            return ok;
        }

        public Boolean Actualizar(bool credencial=false)
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Usuarios SET ";
            Sentencia += "Usuario = '" + _Usuario + "',";
            if (credencial)
            {
                Sentencia += " Credencial = sha1('" + _Credencial + "'),";
            }
            Sentencia += " IDEmpleado = " + _IDEmpleado + ", IDRol=" + _IDRol; ;
            Sentencia += " WHERE IDUsuario=" + _IDUsuario + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch
            { }
            return ok;
        }
        public Boolean Eliminar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "DELETE FROM Usuarios ";
            Sentencia += " WHERE IDUsuario=" + _IDUsuario + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch
            { }
            return ok;
        }
    }
}
