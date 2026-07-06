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
            txtPuesto.Location = new Point(21, 103);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(281, 38);
            txtPuesto.TabIndex = 4;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNombreDocente.Location = new Point(21, 59);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del docente";
            txtNombreDocente.Size = new Size(281, 38);
            txtNombreDocente.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTelefono.Location = new Point(21, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(281, 38);
            txtTelefono.TabIndex = 5;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtClave.Location = new Point(21, 15);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(281, 38);
            txtClave.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCorreo.Location = new Point(21, 191);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(281, 38);
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
            pnlDocentes.Location = new Point(167, 127);
            pnlDocentes.Name = "pnlDocentes";
            pnlDocentes.Size = new Size(346, 252);
            pnlDocentes.TabIndex = 1;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(596, 127);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(350, 252);
            pnlUsuario.TabIndex = 2;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(20, 103);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(281, 39);
            cmbPerfil.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(20, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(281, 38);
            txtPassword.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(20, 15);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(281, 38);
            txtUsuario.TabIndex = 3;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocentes.Location = new Point(374, 24);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(231, 62);
            lblDocentes.TabIndex = 3;
            lblDocentes.Text = "Docentes";
            // 
            // lblDocente
            // 
            lblDocente.AutoSize = true;
            lblDocente.BackColor = SystemColors.ActiveCaption;
            lblDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDocente.Location = new Point(188, 100);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new Size(103, 31);
            lblDocente.TabIndex = 4;
            lblDocente.Text = "Docente";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblUsuario.Location = new Point(612, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(97, 31);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // dgvDocentes
            // 
            dgvDocentes.BackgroundColor = SystemColors.ControlLight;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(26, 488);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.Size = new Size(1063, 228);
            dgvDocentes.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonHighlight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(311, 395);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(151, 72);
            btnNuevo.TabIndex = 10;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(468, 395);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 72);
            btnGuardar.TabIndex = 9;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(625, 395);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 72);
            btnEliminar.TabIndex = 8;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pcbLogo
            // 
            pcbLogo.BorderStyle = BorderStyle.Fixed3D;
            pcbLogo.Image = Properties.Resources.student;
            pcbLogo.Location = new Point(653, 9);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(138, 77);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 11;
            pcbLogo.TabStop = false;
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarClave.Location = new Point(808, 444);
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.PlaceholderText = "Buscar por clave";
            txtBuscarClave.Size = new Size(281, 38);
            txtBuscarClave.TabIndex = 12;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 728);
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