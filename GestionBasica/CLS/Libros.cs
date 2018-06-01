using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Libros
    {
        String _IDLibro;
        String _Titulo;
        String _Fecha_Lanzamiento;
        String _Paginas;
        String _Contenidos;
        String _IDAutor;
        String _IDEditorial;
        String _IDCategoria;
        String _Edicion;
        Image _Portada;

        public string IDLibro
        {
            get
            {
                return _IDLibro;
            }

            set
            {
                _IDLibro = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _Titulo;
            }

            set
            {
                _Titulo = value;
            }
        }

        public string Fecha_Lanzamiento
        {
            get
            {
                return _Fecha_Lanzamiento;
            }

            set
            {
                _Fecha_Lanzamiento = value;
            }
        }

        public string Paginas
        {
            get
            {
                return _Paginas;
            }

            set
            {
                _Paginas = value;
            }
        }

        public string Contenidos
        {
            get
            {
                return _Contenidos;
            }

            set
            {
                _Contenidos = value;
            }
        }

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

        public string IDCategoria
        {
            get
            {
                return _IDCategoria;
            }

            set
            {
                _IDCategoria = value;
            }
        }

        public string Edicion
        {
            get
            {
                return _Edicion;
            }

            set
            {
                _Edicion = value;
            }
        }

        public Image Portada
        {
            get
            {
                return _Portada;
            }

            set
            {
                _Portada = value;
            }
        }

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

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty; 
            Sentencia += "INSERT INTO Libros(Titulo, Fecha_Lanzamiento, Paginas, Contenidos, IDAutor, IDEditorial, IDCategoria, Edicion, Portada) VALUES(";
            Sentencia += "'" + _Titulo + "',";
            Sentencia += "'" + _Fecha_Lanzamiento + "',";
            Sentencia += _Paginas + ",";
            Sentencia += "'" + _Contenidos + "',";
            Sentencia += _IDAutor + ",";
            Sentencia += _IDEditorial + ",";
            Sentencia += _IDCategoria + ",";
            Sentencia += "'" + _Edicion + "',";
            Sentencia += "@Portada";
            Sentencia += ");";

            MySqlParameter param = new MySqlParameter("@Portada", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Portada);
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

        public Boolean Actualzar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE Libros SET ";
            Sentencia += "Titulo = '" + _Titulo + "',";
            Sentencia += "Fecha_Lanzamiento = '" + _Fecha_Lanzamiento + "',";
            Sentencia += "Paginas = '" + _Paginas + "',";
            Sentencia += "Contenidos = '" + _Contenidos + "',";
            Sentencia += "IDAutor = " + _IDAutor + ",";
            Sentencia += "IDEditorial = " + _IDEditorial + ",";
            Sentencia += "IDCategoria = " + _IDCategoria + ",";
            Sentencia += "Edicion = '" + _Edicion + "',";
            Sentencia += "Portada= @Portada";
            Sentencia += " WHERE IDLibro=" + _IDLibro + ";";

            MySqlParameter param = new MySqlParameter("@Portada", MySqlDbType.MediumBlob);
            byte[] buffer = Functions.Class1.ImageToByteArray(_Portada);
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
            Sentencia += "DELETE FROM Libros ";
            Sentencia += " WHERE IDLibro=" + _IDLibro + ";";
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
