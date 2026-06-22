using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pryProyecto
{
    internal class clsCarreras
    {
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;

        //Método para cargar datos en el DataGrid
        public DataTable cargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera As Clave, nombreCarrera AS Carrera, descripcion AS Descripción from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexion"+ex.Message);
            }
            return tabla;
        }
    }
}
