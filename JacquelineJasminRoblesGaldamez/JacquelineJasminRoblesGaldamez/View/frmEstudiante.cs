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
    public partial class frmEstudiante : Form 

    {
        Estudiantes Student = new Estudiantes();
        DialogResult resultado;
        public frmEstudiante()
        {
            InitializeComponent();

            Cargardatos();
            offEditar();

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            
        }

        public void Cargardatos ()
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                var list = from Estud in db.Estudiantes
                           select new { Id = Estud.idEstudiante, Nombre = Estud.Nombre, 
                               Apellido = Estud.Apellido, Usuario = Estud.Usuario, Contraseña = Estud.Contraseña};
                dgvEstudiante.DataSource = list.ToList();

            }
        }

        public void Eliminar()
        {
            txtApellido.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ControlNotasEntities db = new ControlNotasEntities())
            {
                Student.Nombre = txtNombre.Text;
                Student.Apellido = txtApellido.Text;
                Student.Contraseña = txtContraseña.Text;
                Student.Usuario = txtUsuario.Text;
                db.Estudiantes.Add(Student);
                db.SaveChanges();
                Cargardatos();
                Eliminar();
            }
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = dgvEstudiante.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = nombre;
            string apellido = dgvEstudiante.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = apellido;
            string usuario = dgvEstudiante.CurrentRow.Cells[3].Value.ToString();
            txtUsuario.Text = usuario;
            string contraseña = dgvEstudiante.CurrentRow.Cells[4].Value.ToString();
            txtContraseña.Text = contraseña;
            onEditar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Esta seguro de realizar el cambio?","Notificacion",MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (resultado == DialogResult.Yes)
            {
                using (ControlNotasEntities db = new ControlNotasEntities())
                {
                    string id = dgvEstudiante.CurrentRow.Cells[0].Value.ToString();
                    int Id = int.Parse(id);
                    Student = db.Estudiantes.Where(verificarid => verificarid.idEstudiante == Id).First();
                    Student.Nombre = txtNombre.Text;
                    Student.Apellido = txtApellido.Text;
                    Student.Contraseña = txtContraseña.Text;
                    Student.Usuario = txtUsuario.Text;
                    db.Entry(Student).State = System.Data.Entity.EntityState.Modified;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            resultado = MessageBox.Show("¿Esta seguro de Eliminar los datos?", "Notificacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (resultado == DialogResult.Yes)
            {
                using (ControlNotasEntities db = new ControlNotasEntities())
                {
                    string id = dgvEstudiante.CurrentRow.Cells[0].Value.ToString();
                    int Id = int.Parse(id);
                    Student = db.Estudiantes.Find(Id);
                    Student.Nombre = txtNombre.Text;
                    Student.Apellido = txtApellido.Text;
                    Student.Contraseña = txtContraseña.Text;
                    Student.Usuario = txtUsuario.Text;
                    db.Estudiantes.Remove(Student);
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
