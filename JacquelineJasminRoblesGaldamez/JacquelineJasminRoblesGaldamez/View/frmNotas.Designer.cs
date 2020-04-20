namespace JacquelineJasminRoblesGaldamez.View
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbNota = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estudiante,
            this.Materia,
            this.Nota,
            this.Id_Materia,
            this.Id_Estudiante});
            this.dgvNotas.Location = new System.Drawing.Point(41, 142);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(615, 215);
            this.dgvNotas.TabIndex = 0;
            this.dgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Id_Materia
            // 
            this.Id_Materia.HeaderText = "Id_Materia";
            this.Id_Materia.Name = "Id_Materia";
            this.Id_Materia.ReadOnly = true;
            this.Id_Materia.Visible = false;
            // 
            // Id_Estudiante
            // 
            this.Id_Estudiante.HeaderText = "Id_Estudiante";
            this.Id_Estudiante.Name = "Id_Estudiante";
            this.Id_Estudiante.ReadOnly = true;
            this.Id_Estudiante.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(708, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(708, 231);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(708, 318);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notas";
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(339, 76);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(155, 21);
            this.cmbMateria.TabIndex = 6;
            // 
            // cmbNota
            // 
            this.cmbNota.FormattingEnabled = true;
            this.cmbNota.Location = new System.Drawing.Point(585, 76);
            this.cmbNota.Name = "cmbNota";
            this.cmbNota.Size = new System.Drawing.Size(156, 21);
            this.cmbNota.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estudiante";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(78, 76);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(158, 21);
            this.cmbEstudiante.TabIndex = 9;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 426);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstudiante;
    }
}