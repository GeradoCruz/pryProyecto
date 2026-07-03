namespace pryProyecto
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvAlumnos = new DataGridView();
            txtMatriculaAlumno = new TextBox();
            txtMatricula = new TextBox();
            txtPromedio = new TextBox();
            txtDireccion = new TextBox();
            txtAMaterno = new TextBox();
            txtAPaterno = new TextBox();
            txtNombreAlumno = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            cmbTutores = new ComboBox();
            cmbCarreras = new ComboBox();
            pnlAlumno = new Panel();
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            txtPassword = new TextBox();
            cmbPerfil = new ComboBox();
            pnlUsuario = new Panel();
            label2 = new Label();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            pnlAlumno.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonHighlight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(25, 303);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(132, 54);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(183, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 54);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(344, 303);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 54);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Coral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(23, 363);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 45;
            dgvAlumnos.Size = new Size(930, 171);
            dgvAlumnos.TabIndex = 8;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaAlumno.Location = new Point(602, 324);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.PlaceholderText = "Buscar por matrícula";
            txtMatriculaAlumno.Size = new Size(351, 33);
            txtMatriculaAlumno.TabIndex = 9;
            txtMatriculaAlumno.TextChanged += txtNombre_TextChanged;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMatricula.Location = new Point(25, 18);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(246, 32);
            txtMatricula.TabIndex = 10;
            // 
            // txtPromedio
            // 
            txtPromedio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPromedio.Location = new Point(339, 83);
            txtPromedio.Margin = new Padding(3, 2, 3, 2);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.PlaceholderText = "Promedio";
            txtPromedio.Size = new Size(246, 32);
            txtPromedio.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtDireccion.Location = new Point(25, 150);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(246, 32);
            txtDireccion.TabIndex = 14;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAMaterno.Location = new Point(25, 117);
            txtAMaterno.Margin = new Padding(3, 2, 3, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(246, 32);
            txtAMaterno.TabIndex = 15;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtAPaterno.Location = new Point(25, 84);
            txtAPaterno.Margin = new Padding(3, 2, 3, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(246, 32);
            txtAPaterno.TabIndex = 16;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombreAlumno.Location = new Point(25, 51);
            txtNombreAlumno.Margin = new Padding(3, 2, 3, 2);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.PlaceholderText = "Nombre Alumno";
            txtNombreAlumno.Size = new Size(246, 32);
            txtNombreAlumno.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.Location = new Point(339, 17);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Télefono";
            txtTelefono.Size = new Size(246, 32);
            txtTelefono.TabIndex = 18;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(339, 50);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo Electronico";
            txtCorreo.Size = new Size(246, 32);
            txtCorreo.TabIndex = 19;
            // 
            // cmbTutores
            // 
            cmbTutores.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbTutores.FormattingEnabled = true;
            cmbTutores.Location = new Point(339, 116);
            cmbTutores.Margin = new Padding(3, 2, 3, 2);
            cmbTutores.Name = "cmbTutores";
            cmbTutores.Size = new Size(246, 33);
            cmbTutores.TabIndex = 20;
            // 
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(339, 149);
            cmbCarreras.Margin = new Padding(3, 2, 3, 2);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(246, 33);
            cmbCarreras.TabIndex = 21;
            // 
            // pnlAlumno
            // 
            pnlAlumno.BackColor = SystemColors.ActiveCaption;
            pnlAlumno.BorderStyle = BorderStyle.Fixed3D;
            pnlAlumno.Controls.Add(cmbCarreras);
            pnlAlumno.Controls.Add(cmbTutores);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtNombreAlumno);
            pnlAlumno.Controls.Add(txtAPaterno);
            pnlAlumno.Controls.Add(txtAMaterno);
            pnlAlumno.Controls.Add(txtDireccion);
            pnlAlumno.Controls.Add(txtPromedio);
            pnlAlumno.Controls.Add(txtMatricula);
            pnlAlumno.ForeColor = SystemColors.ButtonHighlight;
            pnlAlumno.Location = new Point(23, 109);
            pnlAlumno.Margin = new Padding(3, 2, 3, 2);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(610, 190);
            pnlAlumno.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 90);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 23;
            label1.Text = "Alumno";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombreUsuario.Location = new Point(18, 16);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtNombreUsuario.Size = new Size(246, 32);
            txtNombreUsuario.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(18, 50);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(246, 32);
            txtPassword.TabIndex = 25;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(18, 117);
            cmbPerfil.Margin = new Padding(3, 2, 3, 2);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(246, 33);
            cmbPerfil.TabIndex = 26;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtNombreUsuario);
            pnlUsuario.Location = new Point(671, 109);
            pnlUsuario.Margin = new Padding(3, 2, 3, 2);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(281, 190);
            pnlUsuario.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 90);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 28;
            label2.Text = "Usuario";
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = SystemColors.ButtonFace;
            pcbLogo.BackgroundImageLayout = ImageLayout.Center;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(546, 10);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(88, 62);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 30;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ButtonFace;
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(344, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 50);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Alumnos";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 546);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(label2);
            Controls.Add(pnlUsuario);
            Controls.Add(label1);
            Controls.Add(pnlAlumno);
            Controls.Add(txtMatriculaAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvAlumnos;
        private TextBox txtMatriculaAlumno;
        private TextBox txtMatricula;
        private TextBox txtPromedio;
        private TextBox txtDireccion;
        private TextBox txtAMaterno;
        private TextBox txtAPaterno;
        private TextBox txtNombreAlumno;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private ComboBox cmbTutores;
        private ComboBox cmbCarreras;
        private Panel pnlAlumno;
        private Label label1;
        private TextBox txtNombreUsuario;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private Panel pnlUsuario;
        private Label label2;
        private PictureBox pcbLogo;
        private Label lblTitulo;
    }
}