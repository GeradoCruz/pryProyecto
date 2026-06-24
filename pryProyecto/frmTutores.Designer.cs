namespace pryProyecto
{
    partial class frmTutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutores));
            txtNombreCompleto = new TextBox();
            txtParentesco = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            lblTutor = new Label();
            btnNuevo = new Button();
            btnGurdar = new Button();
            btnEliminar = new Button();
            pcbLogo = new PictureBox();
            dgvTutor = new DataGridView();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCompleto.Location = new Point(179, 93);
            txtNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Ingrese nombre completo";
            txtNombreCompleto.Size = new Size(466, 34);
            txtNombreCompleto.TabIndex = 0;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(179, 140);
            txtParentesco.Margin = new Padding(3, 4, 3, 4);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Parentesco";
            txtParentesco.Size = new Size(466, 34);
            txtParentesco.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(179, 199);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(466, 34);
            txtDireccion.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(179, 292);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(466, 34);
            txtCorreo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(179, 245);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(466, 34);
            txtTelefono.TabIndex = 4;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(403, 23);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(156, 62);
            lblTutor.TabIndex = 6;
            lblTutor.Text = "Tutor";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlLightLight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(179, 348);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(151, 68);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGurdar
            // 
            btnGurdar.BackColor = SystemColors.ControlLightLight;
            btnGurdar.BackgroundImage = Properties.Resources.Guadar;
            btnGurdar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGurdar.Location = new Point(337, 348);
            btnGurdar.Margin = new Padding(3, 4, 3, 4);
            btnGurdar.Name = "btnGurdar";
            btnGurdar.Size = new Size(151, 68);
            btnGurdar.TabIndex = 8;
            btnGurdar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(495, 348);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 68);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BorderStyle = BorderStyle.Fixed3D;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(746, 93);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(271, 212);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 10;
            pcbLogo.TabStop = false;
            // 
            // dgvTutor
            // 
            dgvTutor.BackgroundColor = SystemColors.ControlLight;
            dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutor.Location = new Point(59, 424);
            dgvTutor.Margin = new Padding(3, 4, 3, 4);
            dgvTutor.Name = "dgvTutor";
            dgvTutor.RowHeadersWidth = 51;
            dgvTutor.Size = new Size(959, 213);
            dgvTutor.TabIndex = 12;
            dgvTutor.SelectionChanged += dgvTutor_SelectionChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(746, 372);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(271, 39);
            txtBuscar.TabIndex = 13;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Formulario_Tutorpng;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1087, 685);
            Controls.Add(txtBuscar);
            Controls.Add(dgvTutor);
            Controls.Add(pcbLogo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGurdar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTutor);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtParentesco);
            Controls.Add(txtNombreCompleto);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCompleto;
        private TextBox txtParentesco;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label lblTutor;
        private Button btnNuevo;
        private Button btnGurdar;
        private Button btnEliminar;
        private PictureBox pcbLogo;
        private DataGridView dgvTutor;
        private TextBox txtBuscar;
    }
}