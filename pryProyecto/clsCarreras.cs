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
        private string nombreCarrera;
        private string descripcion;
        private int idCarrera;//Este atributo es para referenciar en update y delete

        //usamos un adaptador
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;

        //propiedad para el atributo nombreCarrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
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
                throw new Exception("error en la conexion" + ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencias 
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera As Clave, nombreCarrera AS Carrera, descripcion AS Descripción from tblCarreras where nombreCarrera like @carrera;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//liberar el adaptador
                    }//liberar la consulta
                }//libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }


            return tabla;

        }
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";

            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
            {

                switch (tipoOperacion)
                {
                    case 0:
                        //registro nuevo
                        string sqlNew = "insert into tblcarreras(nombreCarrera_descripcion) values(@nombreCarrera, @descripcion)";
                        using (comando = new MySqlCommand(sqlNew, conexion))
                        {
                            comando.Parameters.AddWithValue("idCarrera", idCarrera);
                            comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                            comando.Parameters.AddWithValue("descripcion", descripcion);

                            int filasAfectadas = comando.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                msg = "El registro se guardó correctamente";
                            }
                            else
                            {
                                msg = "Error, no se guardaron los  datos....";
                            }
                        }
                        break;
                }
                return msg;
            }

        }
    }
}