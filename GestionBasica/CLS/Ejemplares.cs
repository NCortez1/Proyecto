using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Ejemplares
    {
        String _IDEjemplar;
        String _N_Ejemplar;
        String _Ubicacion;
        String _Fecha_Ingreso;
        String _Fecha_Salida;
        String _Estado_Libro;
        String _IDLibro;
        String _IDEstado;

        public string IDEjemplar
        {
            get
            {
                return _IDEjemplar;
            }

            set
            {
                _IDEjemplar = value;
            }
        }

        public string N_Ejemplar
        {
            get
            {
                return _N_Ejemplar;
            }

            set
            {
                _N_Ejemplar = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return _Ubicacion;
            }

            set
            {
                _Ubicacion = value;
            }
        }

        public string Fecha_Ingreso
        {
            get
            {
                return _Fecha_Ingreso;
            }

            set
            {
                _Fecha_Ingreso = value;
            }
        }

        public string Fecha_Salida
        {
            get
            {
                return _Fecha_Salida;
            }

            set
            {
                _Fecha_Salida = value;
            }
        }

        public string Estado_Libro
        {
            get
            {
                return _Estado_Libro;
            }

            set
            {
                _Estado_Libro = value;
            }
        }

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

        public string IDEstado
        {
            get
            {
                return _IDEstado;
            }

            set
            {
                _IDEstado = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO Ejemplares(N_Ejemplar, Ubicacion, Fecha_Ingreso, Fecha_Salida, Estado_Libro, IDLibro, IDEstado) VALUES(";
            Sentencia += "'" + _N_Ejemplar + "',";
            Sentencia += "'" + _Ubicacion + "',";
            Sentencia += "'" + _Fecha_Ingreso + "',";
            if (_Fecha_Salida!=null)
            {
                Sentencia += "'" + _Fecha_Salida + "',";
            }else
            {
                Sentencia += "null,";
            }
            Sentencia += "'" + _Estado_Libro + "',";
            Sentencia += _IDLibro + ",";
            Sentencia += _IDEstado;
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
            Sentencia += "UPDATE Ejemplares SET ";
            Sentencia += "N_Ejemplar = '" + _N_Ejemplar + "',";
            Sentencia += "Ubicacion = '" + _Ubicacion + "',";
            Sentencia += "Fecha_Ingreso = '" + _Fecha_Ingreso + "',";
            if (_Fecha_Salida != null)
            {
                Sentencia += "Fecha_Salida = '" + _Fecha_Salida + "',";
            }
            else
            {
                Sentencia += "Fecha_Salida = null,";
            }
            Sentencia += "Estado_Libro = '" + _Estado_Libro + "',";
            Sentencia += "IDLibro = " + _IDLibro + ",";
            Sentencia += "IDEstado = " + IDEstado;
            Sentencia += " WHERE IDEjemplar =" + _IDEjemplar + ";";
            
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
            Sentencia += "DELETE FROM Ejemplares ";
            Sentencia += " WHERE IDEjemplar=" + _IDEjemplar + ";";
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
