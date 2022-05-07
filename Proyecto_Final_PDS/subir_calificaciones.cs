using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Proyecto_Final_PDS
{
    public partial class subir_calificaciones : Form
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = ";server=127.0.0.2;user id=root;database=pds;password=2117";
        string us, ma, par, es;
        int cal;

        public subir_calificaciones()
        {
            InitializeComponent();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            us = usuario.Text;
        }

        private void califacion_TextChanged(object sender, EventArgs e)
        {
            cal = Int32.Parse(califacion.Text);
            if (cal >= 6)
            {
                es = "aprobado";
            }
            else
            {
                es = "reprobado";
            }
        }

        private void SubirBT_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                string Query = "INSERT INTO calificaciones (usuario, calificacion, n_parcial, materia, estado)"
                    + "VALUES (" + "'" + us + "', " +
                                        cal +
                                "'" + par + "', " +
                                "'" + ma + "', " +
                                "'" + es + "');";

                MySqlCommand command = new MySqlCommand(Query, Conexion);
                command.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void LimpiarBT_Click(object sender, EventArgs e)
        {
            usuario.Text = "";
            califacion.Text = "";
            parcial.Text = "";
            califacion.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ma = comboBox1.Text;
        }

        private void parcial_TextChanged(object sender, EventArgs e)
        {
            par = parcial.Text;
        }

        private void subir_calificaciones_Load(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                MessageBox.Show("Conectado con éxito");

                Query.CommandText = "SELECT materia FROM materia";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    string mate = consultar.GetString(i);
                    comboBox1.Items.Add(mate);
                    i += 1;
                }

                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
