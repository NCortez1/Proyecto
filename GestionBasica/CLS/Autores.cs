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
        String _Autor;

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

        public string Autor
        {
            get
            {
                return _Autor;
            }

            set
            {
                _Autor = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Autores(Autor) VALUES(";
            Sentencia += "'" + _Autor + "'";
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
            Sentencia += "Autor='" + _Autor + "'";
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
