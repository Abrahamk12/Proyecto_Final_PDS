using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_PDS
{
    public partial class Login : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = ";server=127.0.0.1;user id=root;database=pds;password=2117";
        string usuario;
        string contraseña;

        public Login()
        {
            InitializeComponent();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            usuario = user.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            contraseña = password.Text;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                MessageBox.Show("Conectado con éxito");
                Conexion.Close();

                Query.CommandText = "SELECT usuario_m FROM maestros WHERER usuario_m = " + "'" + usuario + "'";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    string user = consultar.GetString(0);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
