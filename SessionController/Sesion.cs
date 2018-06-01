using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionController
{
    public sealed class Sesion
    {
        private static volatile Sesion instance;
        private static object syncRoot = new Object();
        private Sesion() { }
        public static Sesion Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Sesion();
                    }
                }
                return instance;
            }
        }



        //PERSONALIZACION

        //ATRIBUTOS
        String _IDUsuario;
        String _Usuario;

        //PROPIEDADES
        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
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
                _Usuario=value;
            }
        }

        //METODOS
        public Boolean ValidarSesion(String pUsuario, String pCredencial)
        {
            Boolean Validado = false;
            DataTable Resultado = new DataTable();
            Resultado=CacheController.Cache.VALIDAR_USUARIO(pUsuario, pCredencial);
            if(Resultado.Rows.Count==1)
            {
                Validado = true;
                _Usuario = Resultado.Rows[0]["Usuario"].ToString();
                _IDUsuario = Resultado.Rows[0]["IDUsuario"].ToString();
            }
            return Validado;
        }
    }
}
