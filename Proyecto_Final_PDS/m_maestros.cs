using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_PDS
{
    public partial class m_maestros : Form
    {
        public m_maestros()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void subirCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subir_calificaciones sub_cal = new subir_calificaciones();
            sub_cal.TopLevel = false;
            panel1.Controls.Add(sub_cal);
            sub_cal.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrar_alumno n_aluumno = new registrar_alumno();
            n_aluumno.TopLevel = false;
            panel1.Controls.Add(n_aluumno);
            n_aluumno.Show();
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscar_alumno b_alumno = new buscar_alumno();
            b_alumno.TopLevel = false;
            panel1.Controls.Add(b_alumno);
            b_alumno.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tUNIVERSIDAD DE SONORA\n\tPROYECTO FINAL\n\tPRACTICA DE DESARROLLO DE SOFTWARE\n\tINTEGRANTES" +
                "\n\tURIEL ABRAHAM LOPEZ FLEISCHER\n\tJULIAN FERNANDO FUENTES TRIAS\n\tJOSE LUIS TERAN SOTO");
        }

        private void m_maestros_Load(object sender, EventArgs e)
        {

        }

        private void matreriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
