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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            txtNombreCompleto.Location = new Point(157, 70);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Ingrese nombre completo";
            txtNombreCompleto.Size = new Size(408, 29);
            txtNombreCompleto.TabIndex = 0;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(157, 105);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Parentesco";
            txtParentesco.Size = new Size(408, 29);
            txtParentesco.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(157, 149);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(408, 29);
            txtDireccion.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(157, 219);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(408, 29);
            txtCorreo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(157, 184);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(408, 29);
            txtTelefono.TabIndex = 4;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(353, 17);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(123, 50);
            lblTutor.TabIndex = 6;
            lblTutor.Text = "Tutor";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlLightLight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(157, 261);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(132, 51);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGurdar
            // 
            btnGurdar.BackColor = SystemColors.ControlLightLight;
            btnGurdar.BackgroundImage = (Image)resources.GetObject("btnGurdar.BackgroundImage");
            btnGurdar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGurdar.Location = new Point(295, 261);
            btnGurdar.Name = "btnGurdar";
            btnGurdar.Size = new Size(132, 51);
            btnGurdar.TabIndex = 8;
            btnGurdar.UseVisualStyleBackColor = false;
            btnGurdar.Click += btnGurdar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(433, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 51);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BorderStyle = BorderStyle.Fixed3D;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(653, 70);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(238, 160);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 10;
            pcbLogo.TabStop = false;
            // 
            // dgvTutor
            // 
            dgvTutor.AllowUserToAddRows = false;
            dgvTutor.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.CadetBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTutor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTutor.EnableHeadersVisualStyles = false;
            dgvTutor.Location = new Point(52, 318);
            dgvTutor.Name = "dgvTutor";
            dgvTutor.RowHeadersWidth = 51;
            dgvTutor.RowTemplate.Height = 35;
            dgvTutor.Size = new Size(839, 160);
            dgvTutor.TabIndex = 12;
            dgvTutor.SelectionChanged += dgvTutor_SelectionChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(653, 279);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar";
            txtBuscar.Size = new Size(238, 33);
            txtBuscar.TabIndex = 13;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Formulario_Tutorpng;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(951, 514);
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