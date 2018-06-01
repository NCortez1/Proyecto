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
        String _Editorial;

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

        public string Editorial
        {
            get
            {
                return _Editorial;
            }

            set
            {
                _Editorial = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Editoriales(Editorial) VALUES(";
            Sentencia += "'" + _Editorial + "'";
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
            Sentencia += "Editorial='" + _Editorial + "'";
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
