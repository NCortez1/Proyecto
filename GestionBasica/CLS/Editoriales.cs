using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Editoriales
    {
        String _IDEditorial;
        String _Nombre;
        String _Direccion;
        String _Telefono;

        public string IDEditorial
        {
            get
            {
                return _IDEditorial;
            }

            set
            {
                _IDEditorial = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Editoriales(Nombre, Direccion, Telefono) VALUES(";
            Sentencia += "'" + _Nombre + "',";
            Sentencia += "'" + _Direccion + "',";
            Sentencia += "'" + _Telefono + "'";
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

        public Boolean Actualzar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Editoriales SET ";
            Sentencia += "Nombre='" + _Nombre + "',";
            Sentencia += "Direccion='" + _Direccion + "',";
            Sentencia += "Telefono='" + _Telefono + "'";
            Sentencia += " WHERE IDEditorial=" + _IDEditorial + ";";
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
            Sentencia += "DELETE FROM Editoriales ";
            Sentencia += " WHERE IDEditorial=" + _IDEditorial + ";";
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
