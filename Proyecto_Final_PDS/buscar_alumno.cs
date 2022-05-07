using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_PDS
{
    public partial class buscar_alumno : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        MySqlDataAdapter Adapter;
        public string sql = ";server=127.0.0.1;user id=root;database=pds;password=2117";
        string usuario;
        

        public buscar_alumno()
        {
            InitializeComponent();
        }

        private void buscar_alumno_Load(object sender, EventArgs e)
        {

        }

        private void usuario_t_TextChanged(object sender, EventArgs e)
        {
            usuario = usuario_t.Text;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM nivel WHERE usuario = " + "'" + usuario + "';";
            string query1 = "SELECT * FROM calificaciones WHERE usuario = " + "'" + usuario + "';";
            string query2 = "SELECT * FROM alumnos WHERE usuario = " + "'" + usuario + "';";
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                Adapter = new MySqlDataAdapter(query, Conexion);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                Adapter = new MySqlDataAdapter(query1, Conexion);
                DataTable dt1 = new DataTable();
                Adapter.Fill(dt1);
                dataGridView2.DataSource = dt1;

                Adapter = new MySqlDataAdapter(query2, Conexion);
                DataTable dts = new DataTable();
                Adapter.Fill(dts);
                dataGridView3.DataSource = dts;

                Conexion.Close();

            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
