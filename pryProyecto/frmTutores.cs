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
            tutores=new clsTutores();
            dgvTutor.DataSource=null;
            dgvTutor.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreComp=txtBuscar.Text;
                dgvTutor.DataSource=tutores.Consultar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
