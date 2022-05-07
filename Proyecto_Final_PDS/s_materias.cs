using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_PDS
{
    public partial class s_materias : Form
    {
        MySqlConnection Conexion;
        MySqlDataAdapter Adapter;
        public string sql = ";server=127.0.0.1;user id=root;database=pds;password=2117";
        string mater, query = "SELECT * FROM materias;";
        public s_materias()
        {
            InitializeComponent();
        }

        private void s_materias_Load(object sender, EventArgs e)
        {

        }

        private void materia_TextChanged(object sender, EventArgs e)
        {
            mater = materia.Text;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                string Query = "INSERT INTO materias (materia)"
                    + "VALUES (" + "'" + mater + "');";

                MySqlCommand command = new MySqlCommand(Query, Conexion);
                command.ExecuteNonQuery();

                Adapter = new MySqlDataAdapter(query, Conexion);
                DataTable dt1 = new DataTable();
                Adapter.Fill(dt1);
                dataGridView1.DataSource = dt1;

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
    }
}
