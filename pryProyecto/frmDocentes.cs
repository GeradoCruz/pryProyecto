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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idClave = 0;
            idUsuario = 0;
            docentes.LimpiarPanel(pnlDocentes);
            docentes.LimpiarPanel(pnlUsuario);
            txtClave.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idClave == 0 ? 0 : 1;

                docentes = new clsDocentes();

                docentes.Clave = int.Parse(txtClave.Text);
                docentes.NombreDocente = string.IsNullOrEmpty(txtNombreDocente.Text) ? null : txtNombreDocente.Text;
                docentes.Puesto = string.IsNullOrEmpty(txtPuesto.Text) ? null : txtPuesto.Text;
                docentes.Telefono = string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text;
                docentes.Correo = string.IsNullOrEmpty(txtCorreo.Text) ? null : txtCorreo.Text;

                //Propiedades del bloque de usuario
                docentes.IdUsuario = idUsuario;
                docentes.NombreUsuario = string.IsNullOrEmpty(txtUsuario.Text) ? null : txtUsuario.Text;
                docentes.Password = string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text;
                docentes.Perfil = cmbPerfil.Text;

                string msg = "";

                //confirmacion de carrera
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que desea actualizar los datos de este docente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = docentes.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = docentes.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                var respuesta = MessageBox.Show($"¿Estás seguro de que deseas eliminar este Docente?", "ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {

                        docentes = new clsDocentes();

                        docentes.Clave = idClave;
                        docentes.IdUsuario = idUsuario;

                        string resultado = docentes.Eliminar();

                        MessageBox.Show(resultado, "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtClaveDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveDocente.Text))
            {
                cargarGrid();
                return;
            }
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                docentes.Clave = int.Parse(txtClaveDocente.Text);
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere poner datos" + ex.Message);
            }
        }

    }
}
