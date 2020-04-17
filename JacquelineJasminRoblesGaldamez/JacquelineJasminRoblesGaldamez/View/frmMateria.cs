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
    public partial class frmMateria : Form
    {
        Materias Mat = new Materias();
        DialogResult resultado;

        public frmMateria()
        {
            InitializeComponent();

            Cargardatos();

            Eliminar();
            offEditar();
        }

        public void Cargardatos()
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                var list = from Mater in db.Materias
                           select new { Id = Mater.idMateria, Nombre = Mater.Nombre };
                dgvMaterias.DataSource = list.ToList();


            }
        }
        public void Eliminar()
        {
            txtNombre.Text = "";
        }

        public void offEditar()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }
        public void onEditar()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void frmMateria_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                Mat.Nombre = txtNombre.Text;
                db.Materias.Add(Mat);
                db.SaveChanges();
                Cargardatos();
                Eliminar();


            }
            
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Esta seguro de realizar el cambio?", "Notificacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (resultado == DialogResult.Yes)
            {
                using (ControlNotasEntities db = new ControlNotasEntities())
                {
                    string id = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
                    int Id = int.Parse(id);
                    Mat = db.Materias.Where(verificarid => verificarid.idMateria == Id).First();
                    Mat.Nombre = txtNombre.Text;
                    db.Entry(Mat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Cargardatos();
                    Eliminar();
                    offEditar();

                }


            }
            else
            {
                Cargardatos();
                Eliminar();
                offEditar();
            }


        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nombre = dgvMaterias.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = Nombre;
            onEditar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Esta seguro que desea eliminar los datos?", "Notificacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resultado == DialogResult.Yes)
            {

                using (ControlNotasEntities db = new ControlNotasEntities())
                {

                    string id = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
                    int Id = int.Parse(id);
                    Mat = db.Materias.Find(Id);
                    Mat.Nombre = txtNombre.Text;
                    db.Materias.Remove(Mat);
                    db.SaveChanges();
                    Cargardatos();
                    Eliminar();
                    offEditar();


                }

            }
            else
            {
                Cargardatos();
                Eliminar();
                offEditar();
                
            }
        }
    }
}
