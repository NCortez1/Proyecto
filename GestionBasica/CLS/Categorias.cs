using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Categorias
    {
        String _IDCategoria;
        String _Categoria;

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

        public string Categoria
        {
            get
            {
                return _Categoria;
            }

            set
            {
                _Categoria = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Categorias(Categoria) VALUES(";
            Sentencia += "'" + _Categoria + "'";
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
            Sentencia += "UPDATE Categorias SET ";
            Sentencia += "Categoria='" + _Categoria + "'";
            Sentencia += " WHERE IDCategoria=" + _IDCategoria + ";";
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
            Sentencia += "DELETE FROM Categorias ";
            Sentencia += " WHERE IDCategoria=" + _IDCategoria + ";";
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
