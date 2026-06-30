namespace pryProyecto
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            textBox1 = new TextBox();
            pcbLogo = new PictureBox();
            txtNombreCarrera = new TextBox();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ButtonFace;
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(363, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 62);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.BackColor = SystemColors.ButtonFace;
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(txtDescripcion);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.ForeColor = SystemColors.AppWorkspace;
            pnlAgrupaControles.Location = new Point(75, 133);
            pnlAgrupaControles.Margin = new Padding(3, 4, 3, 4);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(939, 243);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ButtonHighlight;
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(238, 151);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(151, 72);
            btnNuevo.TabIndex = 4;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonHighlight;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(418, 151);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 72);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(602, 151);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 72);
            btnEliminar.TabIndex = 2;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(238, 96);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripcion de la carrera";
            txtDescripcion.Size = new Size(433, 42);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(238, 23);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(433, 42);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dgvCarreras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarreras.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Coral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(75, 440);
            dgvCarreras.Margin = new Padding(3, 4, 3, 4);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowHeadersWidth = 51;
            dgvCarreras.RowTemplate.Height = 45;
            dgvCarreras.Size = new Size(939, 188);
            dgvCarreras.TabIndex = 3;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1176, 484);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 42);
            textBox1.TabIndex = 4;
            textBox1.Text = "Buscar Carrera";
            // 
            // pcbLogo
            // 
            pcbLogo.BackgroundImageLayout = ImageLayout.None;
            pcbLogo.BorderStyle = BorderStyle.FixedSingle;
            pcbLogo.Image = Properties.Resources.sombrero;
            pcbLogo.Location = new Point(594, 42);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(100, 83);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 5;
            pcbLogo.TabStop = false;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(798, 385);
            txtNombreCarrera.Margin = new Padding(3, 4, 3, 4);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Buscar Carrera";
            txtNombreCarrera.Size = new Size(202, 39);
            txtNombreCarrera.TabIndex = 6;
            txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1087, 685);
            Controls.Add(txtNombreCarrera);
            Controls.Add(pcbLogo);
            Controls.Add(textBox1);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCarreras";
            Text = "Registro de Carreras";
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvCarreras;
        private TextBox textBox1;
        private PictureBox pcbLogo;
        private TextBox txtNombreCarrera;
    }
}