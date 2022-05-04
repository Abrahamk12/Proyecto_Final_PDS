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
            login log = new login();
            log.TopLevel = false;
            panel1.Controls.Add(log);
            log.Show();
        }
    }
}
