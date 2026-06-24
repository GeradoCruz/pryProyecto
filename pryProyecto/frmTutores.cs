using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyecto
{
    public partial class frmTutores : Form
    {
        clsTutores tutores;
        int idTutores;
        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            tutores = new clsTutores();
            dgvTutor.DataSource = null;
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutor.DataSource = tutores.cargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutor.DataSource = null;
            dgvTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreComp = txtBuscar.Text;
                dgvTutor.DataSource = tutores.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tutores.IdTutor = idTutores;
                var resp = MessageBox.Show("Confirmar que se desea elminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = tutores.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutores = 0;
            txtNombreCompleto.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombreCompleto.Focus();
        }

        private void dgvTutor_SelectionChanged(object sender, EventArgs e)
        {
            //este es el campo oculto que me servira de referencia para actualizar y eliminar
            idTutores = int.Parse(dgvTutor.CurrentRow.Cells[0].Value.ToString());

            txtNombreCompleto.Text = dgvTutor.CurrentRow.Cells[1].Value.ToString();
            txtParentesco.Text = dgvTutor.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvTutor.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvTutor.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvTutor.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGurdar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idTutores == 0 ? 0 : 1;
                tutores.IdTutor = idTutores;
                tutores.NombreComp = txtNombreCompleto.Text;
                tutores.Parentesco = txtParentesco.Text;
                tutores.Direccion = txtDireccion.Text;
                tutores.Telefono = txtTelefono.Text;
                tutores.Correo = txtCorreo.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = tutores.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = tutores.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }


                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
