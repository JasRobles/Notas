using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JacquelineJasminRoblesGaldamez.Model;

namespace JacquelineJasminRoblesGaldamez.View
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                var lista = from Students in db.Estudiantes
                            where Students.Usuario == txtUsuario.Text
                            && Students.Contraseña == txtContraseña.Text
                            select Students;
                if (lista.Count() > 0)
                {
                    frmControl f = new frmControl();
                    f.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Usuario o Contraseña no existe");
                }

            }
        }
    }
}
