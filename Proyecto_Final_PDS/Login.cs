using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Proyecto_Final_PDS
{
    public partial class Login : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = ";server=127.0.0.2;user id=root;database=pds;password=2117";
        string usuario;

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

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            m_maestros maestros = new m_maestros();
            int i = 0;
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                Query.CommandText = "SELECT usuario_m FROM maestros WHERE usuario_m = " + "'" + usuario + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    string user = consultar.GetString(i);
                    if(usuario == user)
                    {
                        maestros.Show();
                        this.Hide();
                    }
                    i++;
                }

                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
