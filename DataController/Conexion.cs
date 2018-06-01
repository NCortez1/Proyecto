using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataController
{
    public class Conexion
    {
        protected MySqlConnection _CONEXION;
        String _CADENACONEXION = "Server=localhost;Port=3306;Database=sigebdb;Uid=root;Pwd=admin;";
        protected Boolean Conectar()
        {
            Boolean Resultado = false;
            try
            { 
                _CONEXION = new MySqlConnection(_CADENACONEXION);
                _CONEXION.Open();
                if(_CONEXION.State==System.Data.ConnectionState.Open)
                {
                    Resultado = true;

                }
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;
        }
        private void Desconectar()
        {
            try
            {
                if(_CONEXION.State==System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }
    }
}
