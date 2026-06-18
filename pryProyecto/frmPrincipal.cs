using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyecto
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbGeneral_MouseDown(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }

        private void pcbGeneral_MouseUp(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pcbAlumnos.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbDocente.Parent = pcbMenu;
            pcbUsuario.Parent = pcbMenu;
            pcbAlumnos.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbDocente.BackColor = Color.Transparent;
            pcbUsuario.BackColor = Color.Transparent;

            pcbCarreras.Enabled = clsLogin.EsAdministrador;
            pcbDocente.Enabled = clsLogin.EsAdministrador;
            pcbUsuario.Enabled = clsLogin.EsAdministrador;

            pcbAlumnos.Enabled = clsLogin.EsAdministrador || clsLogin.EsDocente;
        }

      
        private void pcbCarreras_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmCarreras(), pnlContenedor);
        }
    }
}
