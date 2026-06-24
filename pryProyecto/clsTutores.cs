using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using System.Diagnostics.CodeAnalysis;

namespace pryProyecto
{
    internal class clsTutores
    {
        private string nombreComp;
        private string parentesco;
        private string direccion;
        private int telefono;
        private string correo;
        private int idTutor;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string NombreComp {  get=>nombreComp; set=>nombreComp=value;}
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }

        public DataTable cargarTabla()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idTutor AS Clave, nombreTutor AS 'Nombre Completo', parentesco AS Parentesco, direccion AS 'Dirección', telefono AS 'Teléfono', correo AS Correo from tbltutores;";
                    using(consulta=new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error en laa conexion" + ex.Message);
            }
            return tabla;
        }
        //Metodo de consulta para buscar
        public DataTable Consultar()
        {
            tabla=new DataTable();
            try
            {
                clsConexion conexionBD=new clsConexion();
                using(var conexion=conexionBD.AbrirConexion())
                {
                    string sql = "select idTutor AS Clave, nombreTutor AS 'Nombre Completo', parentesco AS Parentesco, direccion AS 'Dirección', telefono AS 'Teléfono', correo AS Correo from tbltutores where nombreTutor like @nombreTutor ;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombreTutor", "%" + nombreComp + "%");
                        using(consulta=new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using(var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tbltutores C WHERE C.idTutor = @idtutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTutor ", IdTutor);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }
                }
            }
            catch( Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}
