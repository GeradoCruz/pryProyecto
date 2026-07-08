using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    internal class clsDocentes
    {
        private int clave;
        private string nombreDocente;
        private string puesto;
        private string telefono;
        private string correo;
        private string nombreUsuario;
        private string password;
        private string perfil;
        private int idUsuario;

        private string msg;

        private MySqlCommand comando;
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public int Clave { get => clave; set => clave = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Docente, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo, " +
                                 "D.idUsuario, " +
                                 "U.nombreUsuario AS Usuario, " +
                                 "U.password AS Password, " +
                                 "U.perfil AS Perfil " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.idUsuario; ";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }
        public string GuardarActualizar(int tipoOperacion)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0://insertar uno
                                    //insertamos en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblusuarios(nombreUsuario, password, perfil, estado) VALUES(@nomUser, MD5(@pass), @perfil, 'Activo');SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    //Paso 8: Insertar el alumno en tblalumnos vinculando el ID de usuario obtenido
                                    string sqlInsDocente = "INSERT INTO tbldocentes(claveDocente, idUsuario, nombreDocente, puesto, telefono, correo)\r\nVALUES(@clave, @idUsuario, @nombre,@puesto, @tel, @correo);";

                                    using (comando = new MySqlCommand(sqlInsDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", clave);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "El docente y sus credenciales se guardaron correctamente.";
                                    break;

                                case 1:  //ACTUALIZAR
                                    //PASO A:Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic
                                    string sqlupdUser = "UPDATE tblusuarios SET nombreUsuario = @nomUser, password=MD5(@pass),perfil = @perfil" + " WHERE idUsuario = @idUsuario;";
                                    using (comando = new MySqlCommand(sqlupdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }
                                    //PASO B: Actualizar los datos del expediente en tblalumnos mediante su matricula
                                    string sqlUpdDocente = "UPDATE tbldocentes SET nombreDocente=@nombre, puesto = @puesto, telefono =@tel,correo=@correo" + " WHERE claveDocente=@clave;";

                                    using (comando = new MySqlCommand(sqlUpdDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", clave);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Los datos del docente se actualizaron correctamente.";
                                    break;
                            }
                            //si todo se ejecuto sin errores en el switch, confirmamos los cambios en le BD 
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            //si algo fallo (en el usuario o en el alumno), deshasemos todo para evitar inconsistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error de conexion: " + ex.Message);
            }
            return msg;

        }//finaliza el metodo
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        public string Eliminar()
        {
            string msg = "";

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {

                            string sqlDelDocente = "DELETE FROM tbldocentes WHERE claveDocente = @clave;";
                            using (comando = new MySqlCommand(sqlDelDocente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@clave", clave);
                                comando.ExecuteNonQuery();
                            }


                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE idUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            // si en ambas se elimina correctamente
                            transaccion.Commit();
                            msg = "El Docente y sus credenciales de usuario han sido eliminados del sistema.";
                        }
                        catch (Exception ex)
                        {
                            // Si algo falla, deshacemos la operación para no dejar datos huérfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminación. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión al eliminar: " + ex.Message);
            }

            return msg;
        }

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Docente, " +
                                 "D.puesto AS Puesto, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo, " +
                                 "D.idUsuario, " +
                                 "U.nombreUsuario AS Usuario, " +
                                 "U.password AS Password, " +
                                 "U.perfil AS Perfil " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.idUsuario WHERE D.claveDocente LIKE @clave; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@clave", clave);
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }
    }
}
