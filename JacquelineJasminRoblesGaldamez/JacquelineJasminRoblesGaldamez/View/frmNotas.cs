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
    public partial class frmNotas : Form
    {
        Notas n = new Notas();
        string Student = "";
        string Mat = "";
        DialogResult result;
        public frmNotas()
        {
            InitializeComponent();

            Cargardatos();
            CargarCombo();
        }

        public void Cargardatos()
        {
            dgvNotas.Rows.Clear();
            using (ControlNotasEntities db = new ControlNotasEntities())
            {

                var list = from note in db.Notas
                           from Mat in db.Materias
                           from Stud in db.Estudiantes
                           where note.idEstudiante == Stud.idEstudiante && note.idMateria == Mat.idMateria
                           select new
                           {
                               note.idNota,
                               Stud.Nombre,
                               materia = Mat.Nombre,
                               note.Nota,
                               Mat.idMateria,
                               Stud.idEstudiante
                           };
                foreach (var iterar in list)
                {
                    dgvNotas.Rows.Add(iterar.idNota, iterar.Nombre, iterar.materia, iterar.Nota, iterar.idMateria,
                        iterar.idEstudiante);
                }


            }


        }

        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student = cmbEstudiante.SelectedValue.ToString();

        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mat = cmbMateria.SelectedValue.ToString();
        }

        public void CargarCombo()
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                var estud = db.Estudiantes.ToList();
                if (estud.Count > 0)
                {
                    cmbEstudiante.DataSource = estud;
                    cmbEstudiante.DisplayMember = "nombre";
                    cmbEstudiante.ValueMember = "id_Estudiante";

                }
                var materias = db.Materias.ToList();
                if (materias.Count > 0)
                {
                    cmbMateria.DataSource = materias;
                    cmbMateria.DisplayMember = "nombre_Materia";
                    cmbMateria.ValueMember = "id_Materia";

                }
            }
        }

        private void Notas_Load(object sender, EventArgs e)
        {



        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
