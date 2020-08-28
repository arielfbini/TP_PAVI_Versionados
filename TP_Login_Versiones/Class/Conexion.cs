using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TP_Login_Versiones.Class
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["CadenaDB"]);
        private SqlCommand comando = new SqlCommand();

       
        public void CONECTAR()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();

                }
            }
            catch
            {
                MessageBox.Show("Error al establecer conexion");
            }

        }

        public void DESCONECTAR()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }


            }
            catch
            {
                MessageBox.Show("Error al finalizar conexion");
            }

        }

        public bool VALIDAR_USUARIO(string usuario, string password)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO='" + usuario + "' AND PASSWORD='" + password + "'";

            CONECTAR();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(table);

            DESCONECTAR();

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Inicio de sesion correcto");
                return true;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
                return false;
            }
        }
    }
}
