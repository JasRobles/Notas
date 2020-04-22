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
            offEditar();
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

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
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
                var Est = db.Estudiantes.ToList();
                if (Est.Count > 0)
                {
                    cmbEstudiante.DataSource = Est;
                    cmbEstudiante.DisplayMember = "nombre";
                    cmbEstudiante.ValueMember = "idEstudiante";

                }
                var materias = db.Materias.ToList();
                if (materias.Count > 0)
                {
                    cmbMateria.DataSource = materias;
                    cmbMateria.DisplayMember = "nombre";
                    cmbMateria.ValueMember = "idMateria";

                }
            }
        }

     
        public void offEditar()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        public void onGuardar()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void Notas_Load(object sender, EventArgs e)
        {



        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string notas = dgvNotas.CurrentRow.Cells[3].Value.ToString();
            txtNota.Text = notas;
            string Materia = dgvNotas.CurrentRow.Cells[4].Value.ToString();
            Mat = Materia;
            string Estud = dgvNotas.CurrentRow.Cells[5].Value.ToString();
            Student = Estud;

            onGuardar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                int E = int.Parse(Student);
                n.idEstudiante = E;
                int M = int.Parse(Mat);
                n.idMateria = M;
                string note = txtNota.Text;
                double N = double.Parse(note);
                n.Nota = N;
                db.Notas.Add(n);
                db.SaveChanges();
                Cargardatos();
                txtNota.Text = "";
            }
           



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                result = MessageBox.Show("¿Desea realizar los cambios?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    string id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                    int ID = int.Parse(id);
                    n = db.Notas.Where(verificarId => verificarId.idNota == ID).First();
                    int E = int.Parse(Student);
                    n.idEstudiante = E;
                    int Materia = int.Parse(Mat);
                    n.idMateria = Materia;
                    string nota = txtNota.Text;
                    double N = double.Parse(nota);
                    n.Nota = N;
                    db.Entry(n).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    offEditar();
                    Cargardatos();
                    cmbEstudiante.Enabled = true;
                    cmbMateria.Enabled = true;
                    txtNota.Text = "";


                }
                else
                {
                    offEditar();
                    txtNota.Text = "";
                    cmbEstudiante.Enabled = true;
                    cmbMateria.Enabled = true;
                }

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                result = MessageBox.Show("¿Desea eliminar este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    string id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                    int ID = int.Parse(id);

                    n = db.Notas.Find(ID);
                    db.Notas.Remove(n);
                    db.SaveChanges();
                    Cargardatos();
                    txtNota.Text = "";
                    offEditar();
                }
                else
                {
                    txtNota.Text = "";
                }
            }
        }
    }
}
