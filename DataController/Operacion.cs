using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataController
{
    public class Operacion:Conexion
    {
        private Int32 EjecutarSentencia(String pSentencia, MySqlParameter pParameter=null)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                if (base.Conectar())
                {
                    MySqlCommand Comando = new MySqlCommand();
                    Comando.CommandText = pSentencia;
                    if(pParameter != null)
                    {
                        Comando.Parameters.Add(pParameter);
                    }
                    Comando.Connection = base._CONEXION;
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
            }catch
            {
                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            try
            {
                if (base.Conectar())
                {
                    MySqlCommand Comando = new MySqlCommand();
                    MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                    Comando.CommandText = pConsulta;
                    Comando.Connection = base._CONEXION;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                }
            }
            catch
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }
        public Int32 Insertar(String pSentencia, MySqlParameter pParameter = null)
        {
            return EjecutarSentencia(pSentencia,pParameter);
        }
        public Int32 Actualizar(String pSentencia, MySqlParameter pParameter = null)
        {
            return EjecutarSentencia(pSentencia,pParameter);
        }
        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
    }
}
