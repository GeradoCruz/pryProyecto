namespace pryProyecto
{
    partial class frmDocentes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            txtPuesto = new TextBox();
            txtNombreDocente = new TextBox();
            txtTelefono = new TextBox();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            pnlDocentes = new Panel();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            lblDocentes = new Label();
            lblDocente = new Label();
            lblUsuario = new Label();
            dgvDocentes = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            pcbLogo = new PictureBox();
            txtBuscarClave = new TextBox();
            pnlDocentes.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPuesto.Location = new Point(18, 77);
            txtPuesto.Margin = new Padding(3, 2, 3, 2);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(246, 32);
            txtPuesto.TabIndex = 4;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombreDocente.Location = new Point(18, 44);
            txtNombreDocente.Margin = new Padding(3, 2, 3, 2);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del docente";
            txtNombreDocente.Size = new Size(246, 32);
            txtNombreDocente.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.Location = new Point(18, 110);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(246, 32);
            txtTelefono.TabIndex = 5;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtClave.Location = new Point(18, 11);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(246, 32);
            txtClave.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(18, 143);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(246, 32);
            txtCorreo.TabIndex = 6;
            // 
            // pnlDocentes
            // 
            pnlDocentes.BackColor = SystemColors.ActiveCaption;
            pnlDocentes.Controls.Add(txtCorreo);
            pnlDocentes.Controls.Add(txtClave);
            pnlDocentes.Controls.Add(txtTelefono);
            pnlDocentes.Controls.Add(txtNombreDocente);
            pnlDocentes.Controls.Add(txtPuesto);
            pnlDocentes.Location = new Point(146, 95);
            pnlDocentes.Margin = new Padding(3, 2, 3, 2);
            pnlDocentes.Name = "pnlDocentes";
            pnlDocentes.Size = new Size(303, 189);
            pnlDocentes.TabIndex = 1;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(522, 95);
            pnlUsuario.Margin = new Padding(3, 2, 3, 2);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(306, 189);
            pnlUsuario.TabIndex = 2;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor " });
            cmbPerfil.Location = new Point(18, 77);
            cmbPerfil.Margin = new Padding(3, 2, 3, 2);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(246, 33);
            cmbPerfil.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(18, 44);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(246, 32);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(18, 11);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(246, 32);
            txtUsuario.TabIndex = 3;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocentes.Location = new Point(327, 18);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(188, 51);
            lblDocentes.TabIndex = 3;
            lblDocentes.Text = "Docentes";
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.BackColor = SystemColors.ActiveCaption;
            lblDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDocente.Location = new Point(164, 75);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(86, 25);
            lblDocente.TabIndex = 4;
            lblDocente.Text = "Docente";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblUsuario.Location = new Point(536, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(23, 366);
            dgvDocentes.Margin = new Padding(3, 2, 3, 2);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.Size = new Size(930, 171);
            dgvDocentes.TabIndex = 6;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonHighlight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(272, 296);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(132, 54);
            btnNuevo.TabIndex = 10;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(410, 296);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 54);
            btnGuardar.TabIndex = 9;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(547, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 54);
            btnEliminar.TabIndex = 8;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BorderStyle = BorderStyle.Fixed3D;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(571, 7);
            pcbLogo.Margin = new Padding(3, 2, 3, 2);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(121, 59);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 11;
            pcbLogo.TabStop = false;
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarClave.Location = new Point(707, 333);
            txtBuscarClave.Margin = new Padding(3, 2, 3, 2);
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.PlaceholderText = "Buscar por clave";
            txtBuscarClave.Size = new Size(246, 32);
            txtBuscarClave.TabIndex = 12;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 546);
            Controls.Add(txtBuscarClave);
            Controls.Add(pcbLogo);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDocentes);
            Controls.Add(lblUsuario);
            Controls.Add(lblDocente);
            Controls.Add(lblDocentes);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlDocentes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDocentes";
            Text = "frmDocentes";
            pnlDocentes.ResumeLayout(false);
            pnlDocentes.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPuesto;
        private TextBox txtNombreDocente;
        private TextBox txtTelefono;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private Panel pnlDocentes;
        private Panel pnlUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lblDocentes;
        private Label lblDocente;
        private Label lblUsuario;
        private DataGridView dgvDocentes;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox cmbPerfil;
        private PictureBox pcbLogo;
        private TextBox txtBuscarClave;
    }
}