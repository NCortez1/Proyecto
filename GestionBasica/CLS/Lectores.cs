using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Lectores
    {
        String _IDLector;
        String _Usuario;
        String _Credencial;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Genero;
        String _MaxPrestamo;
        String _Credibilidad;
        String _MaxTiempoPrestamo;
        String _Fecha_inicio;
        Image _Foto;

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

        public string MaxPrestamo
        {
            get
            {
                return _MaxPrestamo;
            }

            set
            {
                _MaxPrestamo = value;
            }
        }

        public string Credibilidad
        {
            get
            {
                return _Credibilidad;
            }

            set
            {
                _Credibilidad = value;
            }
        }

        public string MaxTiempoPrestamo
        {
            get
            {
                return _MaxTiempoPrestamo;
            }

            set
            {
                _MaxTiempoPrestamo = value;
            }
        }

        public string Fecha_inicio
        {
            get
            {
                return _Fecha_inicio;
            }

            set
            {
                _Fecha_inicio = value;
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

        public string IDLector
        {
            get
            {
                return _IDLector;
            }

            set
            {
                _IDLector = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO lectores(Usuario, Credencial, Nombres, Apellidos, FechaNacimiento, Genero, MaxPrestamo, Credibilidad, MaxTiempoPrestamo, Fecha_Inicio, Foto) VALUES(";
            Sentencia += "'" + _Usuario + "',";
            Sentencia += "SHA1('" + _Credencial + "'),";
            Sentencia += "'" + _Nombres + "',";
            Sentencia += "'" + _Apellidos + "',";
            Sentencia += "'" + _FechaNacimiento + "',";
            Sentencia += "'" + _Genero + "',";
            Sentencia += "'" + _MaxPrestamo + "',";
            Sentencia += "'" + _Credibilidad + "',";
            Sentencia += "'" + _MaxTiempoPrestamo + "',";
            Sentencia += "'" + _Fecha_inicio + "',";
            Sentencia += "@Foto";
            Sentencia += ");";

            MySqlParameter param = new MySqlParameter("@Foto", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Foto);
            param.Size = buffer.Length;
            param.Value = buffer;
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia, param) > 0)
                {
                    ok = true;
                }
            }
            catch
            { }
            return ok;
        }

        public Boolean Actualzar(bool credencial = false)
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Lectores SET ";
            Sentencia += "Usuario = '" + _Usuario + "',";
            if (credencial)
            {
                Sentencia += " Credencial = sha1('" + _Credencial + "'),";
            }
            Sentencia += "Nombres = '" + _Nombres + "',";
            Sentencia += "Apellidos = '" + _Apellidos + "',";
            Sentencia += "FechaNacimiento = '" + _FechaNacimiento + "',";
            Sentencia += "Genero='" + _Genero + "',";
            Sentencia += "Fecha_Inicio = '" + _Fecha_inicio + "',";
            Sentencia += "Foto= @Foto";
            Sentencia += " WHERE IDLector=" + _IDLector + ";";

            MySqlParameter param = new MySqlParameter("@Foto", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Foto);
            param.Size = buffer.Length;
            param.Value = buffer;
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia, param) > 0)
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
            Sentencia += "DELETE FROM Lectores ";
            Sentencia += " WHERE IDLector=" + _IDLector + ";";
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
