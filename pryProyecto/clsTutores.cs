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
        private string telefono;
        private string correo;
        private int idTutor;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string NombreComp {  get=>nombreComp; set=>nombreComp=value;}
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
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

        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    switch (tipoOperacion)
                    {
                        case 0:
                            //registro nuevo
                            string sqlN = "insert into tbltutores  (nombreTutor,parentesco,direccion,telefono,correo) values(@nombreTutor, @parentesco, @direccion,@telefono,@correo)";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreComp);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

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
                        case 1:
                            string sqlA = "UPDATE tbltutores C SET C.nombreTutor = @nombreTutor, C.parentesco = @parentesco, C.direccion = @direccion, C.telefono = @telefono, C.correo = @correo WHERE C.idTutor = @idTutor";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {

                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreComp);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

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

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
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
