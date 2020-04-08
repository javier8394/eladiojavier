using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ControlCotizaciones.Carpeta_Clases
{
    class ClaConexion
    {
        private MySqlConnection conexion;
        private string DB;
        private string Usuario;
        private string pass;
        //private string host;
        private string servidor;
        public ClaConexion()
        {
            conexion = new MySqlConnection();
            DB = "dbicma";
            Usuario = "root";
            pass = "";
            servidor = "127.0.0.1";
        }
        public Boolean EstablecerConexion()
        {
            Boolean r = false;
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.ConnectionString = string.Format("server={0}; user id={1}; password={2}; persistsecurityinfo=True; database={3}", servidor, Usuario, pass, DB);
                conexion.Open();
                r = true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(string.Format("Error: {0}", e.ToString()));
                r = false;
            }

            return r;
        }

        internal void Conectar()
        {
            throw new NotImplementedException();
        }

        public DataTable consultar(string sql)
        {
            DataTable tabla = new DataTable();
            EstablecerConexion();
            MySqlCommand comando = conexion.CreateCommand();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = sql;
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(string.Format("Error: \n{0}", ex.ToString()), "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public Boolean Ejecutar(string sql)
        {
            EstablecerConexion();
            MySqlCommand comando = conexion.CreateCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            return true;
        }
    }
}
