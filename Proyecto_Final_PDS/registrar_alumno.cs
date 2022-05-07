using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_PDS
{
    public partial class registrar_alumno : Form
    {
        MySqlConnection Conexion;
        MySqlDataAdapter Adapter;
        public string sql = ";server=127.0.0.2;user id=root;database=pds;password=2117";
        string nom, us, dir, cor, cel, tu, cel_e, fe;

        public registrar_alumno()
        {
            InitializeComponent();
        }

        private void registrar_alumno_Load(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            nom = nombre.Text;
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            us = usuario.Text;
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            dir = direccion.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {
            cor = correo.Text;
        }

        private void celular_TextChanged(object sender, EventArgs e)
        {
            cel = celular.Text;
        }

        private void tutor_TextChanged(object sender, EventArgs e)
        {
            tu = tutor.Text;
        }

        private void cel_em_TextChanged(object sender, EventArgs e)
        {
            cel_e = cel_em.Text;
        }

        private void fecha_TextChanged(object sender, EventArgs e)
        {
            fe = fecha.Text;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM alumnos WHERER usuario = " + "'" + usuario + "'";
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();

                string Query = "INSERT INTO alumnos (nom_completo, usuario, direccion, correo, celular, tutor, num_emergencia, fecha_nacimiento)" 
                    + "VALUES (" + "'" + nom + "', " + 
                                "'" + us + "', " + 
                                "'" + dir + "', " +
                                "'" + cor + "', " +
                                "'" + cel + "', " +
                                "'" + tu + "', " +
                                "'" + cel_e + "', " +
                                "'" + fe + "');";

                MySqlCommand command = new MySqlCommand(Query, Conexion);
                command.ExecuteNonQuery();

                Adapter = new MySqlDataAdapter(query, Conexion);
                DataTable dt1 = new DataTable();
                Adapter.Fill(dt1);
                dataGridView1.DataSource = Adapter.Fill(dt1);

                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            usuario.Text = "";
            direccion.Text = "";
            correo.Text = "";
            celular.Text = "";
            tutor.Text = "";
            cel_em.Text = "";
            fecha.Text = "año-mes-dia";
        }
    }
}
