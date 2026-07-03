using MySqlConnector;
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
            cargarGrid();
            CargarCombos();
        }
        public void cargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
                dgvAlumnos.Columns["Usuario"].Visible = false;
                dgvAlumnos.Columns["password"].Visible = false;
                dgvAlumnos.Columns["perfil"].Visible = false;
                dgvAlumnos.Columns["direccion"].Visible = false;
                dgvAlumnos.Columns["correo"].Visible = false;
                dgvAlumnos.Columns["telefono"].Visible = true;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idMatricula = 0;
            idUsuario = 0;
            alumnos.LimpiarPanel(pnlAlumno);
            alumnos.LimpiarPanel(pnlUsuario);
            txtMatricula.Focus();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatriculaAlumno.Text))
            {
                cargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                alumnos.Matricula = int.Parse(txtMatriculaAlumno.Text);
                dgvAlumnos.DataSource = alumnos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere poner datos" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Determinamos el tipo de operacion
                int tipoOperacion = idMatricula == 0 ? 0 : 1;

                alumnos = new clsAlumnos();

                //1.llenamos  las propiedades del bloque alumno
                alumnos.Matricula = int.Parse(txtMatricula.Text);
                alumnos.NombreAlumno = txtNombreAlumno.Text;
                alumnos.ApellidoP = txtAPaterno.Text;
                alumnos.ApellidoM = txtAMaterno.Text;
                alumnos.Direccion = txtDireccion.Text;
                alumnos.Telefono = txtTelefono.Text;
                alumnos.Correo = txtCorreo.Text;
                alumnos.PromedioBachillerato = decimal.Parse(txtPromedio.Text);
                alumnos.IdCarrera = Convert.ToInt32(cmbCarreras.SelectedValue);
                alumnos.IdTutor = Convert.ToInt32(cmbTutores.SelectedValue);

                //2. Llenamos las propiedades del bloque Usuario
                alumnos.IdUsuario = idUsuario; //Sera 0 si es nuevo, o el ID real si es update
                alumnos.NombreUsuario = txtNombreUsuario.Text;
                alumnos.Password = txtPassword.Text;
                alumnos.Perfil = cmbPerfil.Text;

                string msg = "";

                //Si es una modificacion (TipoOperacion=1), pedimos confirmacion como en carreras
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿ Confirmar que deseas actualizar los datos de este alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = alumnos.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    msg = alumnos.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrid(); //Se refresca la tabla del formulario


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estas completamente seguro de eliminar al alumno con matricula:{idMatricula}?\nEsta acción borrará tambien su cuenta de usuario.",
                                "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    alumnos = new clsAlumnos();
                    alumnos.Matricula = idMatricula;
                    alumnos.IdUsuario = idUsuario;

                    string resultado = alumnos.Eliminar();

                    MessageBox.Show(resultado, "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarGrid();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message, "Error operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
