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
    public partial class frmDocentes : Form
    {
        clsDocentes docentes;
        int idClave;
        int idUsuario;
        public frmDocentes()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid()
        {
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDocentes.DataSource = docentes.CargarDataGrid();
                dgvDocentes.Columns["idUsuario"].Visible = false;
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["Password"].Visible = false;
                dgvDocentes.Columns["Perfil"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //conocer si es nuevo o se actualizará
                idClave = int.Parse(dgvDocentes.CurrentRow.Cells["Clave"].Value.ToString());
                idUsuario = int.Parse(dgvDocentes.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Tabla Docente 
                txtClave.Text = idClave.ToString();
                txtNombreDocente.Text = dgvDocentes.CurrentRow.Cells["Docente"].Value.ToString();
                txtPuesto.Text = dgvDocentes.CurrentRow.Cells["Puesto"].Value.ToString();
                txtTelefono.Text = dgvDocentes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvDocentes.CurrentRow.Cells["Correo"].Value.ToString();

                //Tabla de usuarios 
                txtUsuario.Text = dgvDocentes.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvDocentes.CurrentRow.Cells["Password"].Value.ToString();
                cmbPerfil.Text = dgvDocentes.CurrentRow.Cells["Perfil"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados" + ex.Message);
            }
        }
    }
}
