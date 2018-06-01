using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Autores
    {
        String _IDAutor;
        String _Nombre;
        String _Fecha_Nacimiento;
        String _Residencia;

        public string IDAutor
        {
            get
            {
                return _IDAutor;
            }

            set
            {
                _IDAutor = value;
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

        public string Fecha_Nacimiento
        {
            get
            {
                return _Fecha_Nacimiento;
            }

            set
            {
                _Fecha_Nacimiento = value;
            }
        }

        public string Residencia
        {
            get
            {
                return _Residencia;
            }

            set
            {
                _Residencia = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Autores(Nombre, Fecha_Nacimiento, Residencia) VALUES(";
            Sentencia += "'" + _Nombre + "',";
            Sentencia += "'" + _Fecha_Nacimiento + "',";
            Sentencia += "'" + _Residencia + "'";
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
            Sentencia += "UPDATE Autores SET ";
            Sentencia += "Nombre='" + _Nombre + "',";
            Sentencia += "Fecha_Nacimiento='" + _Fecha_Nacimiento + "',";
            Sentencia += "Residencia='" + _Residencia + "'";
            Sentencia += " WHERE IDAutor=" + _IDAutor + ";";
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
            Sentencia += "DELETE FROM Autores ";
            Sentencia += " WHERE IDAutor=" + _IDAutor + ";";
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
