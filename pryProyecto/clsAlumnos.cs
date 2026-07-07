using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace pryProyecto
{
    internal class clsAlumnos
    {
        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;
        private int idTutor;
        private int idCarrera;
        private int idUsuario;

        private string nombreUsuario;
        private string password;
        private string perfil;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.nombreUsuario AS Usuario, " +
                                 "U.password AS password, " +
                                 "U.perfil AS perfil, " +
                                 "A.direccion, " +
                                 "A.telefono, " +
                                 "A.correo, " +
                                 "A.promedioBachillerato, " +
                                 "A.foto, " +
                                 "A.idTutor, " +
                                 "A.idCarrera, " +
                                 "A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.idUsuario;";

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
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "SELECT idTutor, nombreTutor FROM tblTutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //valueMember es el idCarrera y el DisplayMember es el nombre carrera
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.nombreUsuario AS Usuario, " +
                                 "U.password AS password, " +
                                 "U.perfil AS perfil, " +
                                 "A.direccion, " +
                                 "A.telefono, " +
                                 "A.correo, " +
                                 "A.promedioBachillerato, " +
                                 "A.foto, " +
                                 "A.idTutor, " +
                                 "A.idCarrera, " +
                                 "A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.idUsuario WHERE A.matricula LIKE @matricula;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
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

        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
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
                                case 0:

                                    string sqlInsUser = "INSERT INTO tblusuarios(nombreUsuario, password, perfil, estado) " +
                                                        "VALUES(@nombreUsuario,MD5(@password),@perfil,'Activo');SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        
                                        comando.Parameters.AddWithValue("@nombreUsuario", string.IsNullOrEmpty(nombreUsuario));
                                        comando.Parameters.AddWithValue("@password", string.IsNullOrEmpty(password));
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());

                                    }
                                    string sqlInsAlumno = "INSERT INTO tblalumnos(matricula,idUsuario,nombreAlumno,apellidoP,apellidoM,direccion,telefono,correo,promedioBachillerato,idTutor,idCarrera) " +
                                                        "VALUES(@matricula,@idUsuario,@nombreAlumno,@apellidoP,@apellidoM,@direccion,@telefono,@correo,@promedioBachillerato,@idTutor,@idCarrera);";
                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombreAlumno", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                                        comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                                        comando.Parameters.AddWithValue("@direccion", direccion);
                                        comando.Parameters.AddWithValue("@telefono", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@promedioBachillerato", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El alumno y sus credenciales se guardaron correctamente";
                                    break;
                                case 1:
                                    string sqlUpdUser = "UPDATE tblusuarios SET nombreUsuario=@nombreUsuario,perfil = @perfil" +
                                                      " WHERE idUsuario=@idUsuario;";
                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }

                                    string sqlUpdAlumno = "UPDATE tblalumnos SET nombreAlumno=@nombreAlumno,apellidoP=@apellidoP,apellidoM=@apellidoM," +
                                        "direccion=@direccion,telefono=@telefono,correo=@correo,promedioBachillerato=@promedioBachillerato," +
                                        "idTutor=@idTutor,idCarrera=@idCarrera WHERE matricula=@matricula;";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombreAlumno", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                                        comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                                        comando.Parameters.AddWithValue("@direccion", direccion);
                                        comando.Parameters.AddWithValue("@telefono", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@promedioBachillerato", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();

                                    }
                                    msg = "Los datos del alumno se actualizaron correctamente.";
                                    break;

                            }
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. Se cancelaron los cambios:" + ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion:" + ex.Message);
            }
            return msg;
        }
        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string sqlDelAlumno = "DELETE FROM tblalumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }

                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE idUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario se eliminaron correctamente.";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminación. Cambios revertidos:" + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión al eliminar:" + ex.Message);
            }
            return msg;
        }
    }
}
