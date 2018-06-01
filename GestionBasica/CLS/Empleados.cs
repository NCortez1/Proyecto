using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Empleados
    {
        String _IDEmpleado;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Genero;
        Image _Foto;

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

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public Image Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Empleados(Nombres, Apellidos, FechaNacimiento, Genero, Foto) VALUES(";
            Sentencia += "'" + _Nombres + "','";
            Sentencia += _Apellidos + "','";
            Sentencia += _FechaNacimiento + "','";
            Sentencia += _Genero + "',";
            Sentencia += "@Foto";
            Sentencia += ");";

            MySqlParameter param = new MySqlParameter("@Foto", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Foto);
            param.Size = buffer.Length;
            param.Value = buffer;
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia,param) > 0)
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
            Sentencia += "UPDATE Empleados SET ";
            Sentencia += "Nombres = '" + _Nombres + "',";
            Sentencia += "Apellidos = '" + _Apellidos + "',";
            Sentencia += "FechaNacimiento = '" + _FechaNacimiento + "',";
            Sentencia += "Genero='" + _Genero + "',";
            Sentencia += "Foto= @Foto";
            Sentencia += " WHERE IDEmpleado=" + _IDEmpleado + ";";

            MySqlParameter param = new MySqlParameter("@Foto", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Foto);
            param.Size = buffer.Length;
            param.Value = buffer;
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia,param) > 0)
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
            Sentencia += "DELETE FROM Empleados ";
            Sentencia += " WHERE IDEmpleado=" + _IDEmpleado + ";";
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
