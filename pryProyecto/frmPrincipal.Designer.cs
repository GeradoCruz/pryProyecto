namespace pryProyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbMenu = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbUsuario = new PictureBox();
            pcbDocente = new PictureBox();
            pnlContenedor = new Panel();
            pcbTitulo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.AccessibleRole = AccessibleRole.None;
            pcbMenu.BackColor = Color.Transparent;
            pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
            pcbMenu.Location = new Point(12, 32);
            pcbMenu.Margin = new Padding(3, 2, 3, 2);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(280, 698);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.BackColor = Color.Transparent;
            pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
            pcbAlumnos.Location = new Point(33, 126);
            pcbAlumnos.Margin = new Padding(3, 2, 3, 2);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(220, 96);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(33, 263);
            pcbCarreras.Margin = new Padding(3, 2, 3, 2);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(220, 96);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuario
            // 
            pcbUsuario.BackColor = Color.Transparent;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(33, 537);
            pcbUsuario.Margin = new Padding(3, 2, 3, 2);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(220, 96);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 4;
            pcbUsuario.TabStop = false;
            pcbUsuario.MouseDown += pcbGeneral_MouseDown;
            pcbUsuario.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocente
            // 
            pcbDocente.Image = (Image)resources.GetObject("pcbDocente.Image");
            pcbDocente.Location = new Point(33, 404);
            pcbDocente.Margin = new Padding(3, 2, 3, 2);
            pcbDocente.Name = "pcbDocente";
            pcbDocente.Size = new Size(220, 96);
            pcbDocente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocente.TabIndex = 5;
            pcbDocente.TabStop = false;
            pcbDocente.MouseDown += pcbGeneral_MouseDown;
            pcbDocente.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Location = new Point(367, 167);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(967, 553);
            pnlContenedor.TabIndex = 6;
            // 
            // pcbTitulo
            // 
            pcbTitulo.BackColor = Color.Transparent;
            pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
            pcbTitulo.Location = new Point(367, 32);
            pcbTitulo.Margin = new Padding(3, 2, 3, 2);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(967, 101);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1370, 749);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbDocente);
            Controls.Add(pcbUsuario);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbUsuario;
        private PictureBox pcbDocente;
        private Panel pnlContenedor;
        private PictureBox pcbTitulo;
    }
}