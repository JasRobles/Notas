using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JacquelineJasminRoblesGaldamez.View;

namespace JacquelineJasminRoblesGaldamez
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            frmEstudiante c = new frmEstudiante();
            c.MdiParent = this;
            c.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiante c = new frmEstudiante();
            c.MdiParent = this;
            c.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria c = new frmMateria();
            c.MdiParent = this;
            c.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNotas n = new frmNotas();
            n.MdiParent = this;
            n.Show();

        }
    }
}
