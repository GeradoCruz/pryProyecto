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
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;
        int idMatricula;
        int idUsuario;

        public frmAlumnos()
        {
            InitializeComponent();
            CargarCombos();
            cargarGrid();

        }
        public void cargarGrid()
        {
            
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
                dgvAlumnos.Columns["Usuario"].Visible = true;
                dgvAlumnos.Columns["password"].Visible = true;
                dgvAlumnos.Columns["perfil"].Visible = true;
                dgvAlumnos.Columns["direccion"].Visible = true;
                dgvAlumnos.Columns["correo"].Visible = true;
                dgvAlumnos.Columns["telefono"].Visible = true;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = true;
                dgvAlumnos.Columns["idTutor"].Visible = false;
                dgvAlumnos.Columns["idCarrera"].Visible = false;
                dgvAlumnos.Columns["idUsuario"].Visible = false;
                dgvAlumnos.Columns["foto"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCombos()
        {
            alumnos = new clsAlumnos();
            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();

                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idCarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0);

                // Enlazamos los datos al ComboBox visual
                cmbCarreras.DataSource = dtCarreras;
                cmbCarreras.DisplayMember = "nombreCarrera"; // El texto visible
                cmbCarreras.ValueMember = "idCarrera";       // La llave primaria real
                cmbCarreras.SelectedIndex = 0;               // Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerTutores();

                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "-- Selecciona un Tutor --";
                dtTutores.Rows.InsertAt(filaPTutores, 0);


                // Enlazamos los datos al ComboBox visual
                cmbTutores.DataSource = dtTutores;
                cmbTutores.DisplayMember = "nombreTutor";     // El texto visible
                cmbTutores.ValueMember = "idTutor";           // La llave primaria real
                cmbTutores.SelectedIndex = 0;                 // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                //Esto es para poder saber si es nuevo o vamos a actualizar
                idMatricula = int.Parse(dgvAlumnos.CurrentRow.Cells["Matricula"].Value.ToString());
                idUsuario = int.Parse(dgvAlumnos.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Esto es para la tabla alumnos
                txtMatricula.Text = idMatricula.ToString();
                txtNombreAlumno.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Paterno"].Value.ToString();
                txtAMaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Materno"].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvAlumnos.CurrentRow.Cells["correo"].Value.ToString();
                txtPromedio.Text = dgvAlumnos.CurrentRow.Cells["promedioBachillerato"].Value.ToString();

                //Esto es para la tabla usuarios
                txtNombreUsuario.Text = dgvAlumnos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvAlumnos.CurrentRow.Cells["password"].Value.ToString();
                cmbPerfil.Text = dgvAlumnos.CurrentRow.Cells["perfil"].Value.ToString();

                //Usar selected value para apuntar al dato preciso de cada registro
                cmbCarreras.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString());
                cmbTutores.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idTutor"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados" + ex.Message);
            }
        }
    }
}
