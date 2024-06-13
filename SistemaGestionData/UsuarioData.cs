using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaGestionEntities;
using System.Runtime.Serialization;

namespace SistemaGestionData
{
    public static class UsuarioData
    {

        public static List<Usuario> ObtenerUsuario()
        {
            try
            {
                using (SqlConnection connection = ConnectionADO.GetConnection())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    string query = "SELECT * FROM Usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.id = Convert.ToInt32(reader["Id"]);
                        usuario.nombre = reader["Nombre"].ToString();
                        usuario.apellido = reader["Apellido"].ToString();
                        usuario.nombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.contrasenia = reader["Contraseña"].ToString();
                        usuario.mail = reader["Mail"].ToString();

                        usuarios.Add(usuario);
                    }
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseException("Error al obtener todos los usuarios", ex);
            }


        }
        public static Usuario? ObtenerUsuarioPorId(int id)
        {
            try
            {
                List<Usuario> usuarios = UsuarioData.ObtenerUsuario();
                return usuarios.Find(b => b.id == id);

            }
            catch (Exception ex)
            {
                throw new DataBaseException("Error al obtener un usuario por id", ex);
            }

        }

        public static bool BorrarUsuario(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }
        public static bool CrearUsuario(Usuario nuevoUsuario)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) VALUES " +
                    "(@nombre,@apellido,@nombreUsuario,@password,@email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", nuevoUsuario.nombre);
                command.Parameters.AddWithValue("apellido", nuevoUsuario.apellido);
                command.Parameters.AddWithValue("nombreUsuario", nuevoUsuario.nombreUsuario);
                command.Parameters.AddWithValue("password", nuevoUsuario.contrasenia);
                command.Parameters.AddWithValue("email", nuevoUsuario.mail);
                return command.ExecuteNonQuery() > 0;

            }

        }

        public static bool ActualizarUsuario(Usuario nuevoUsuario)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE Usuario SET Nombre = @nombre, Apellido = @apellido, NombreUsuario = @nombreUsuario, Contraseña = @password, Mail = @email WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoUsuario.id);
                command.Parameters.AddWithValue("nombre", nuevoUsuario.nombre);
                command.Parameters.AddWithValue("apellido", nuevoUsuario.apellido);
                command.Parameters.AddWithValue("nombreUsuario", nuevoUsuario.nombreUsuario);
                command.Parameters.AddWithValue("password", nuevoUsuario.contrasenia);
                command.Parameters.AddWithValue("email", nuevoUsuario.mail);
                return command.ExecuteNonQuery() > 0;

            }

        }

        public static void BorrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        [Serializable]
        private class DataBaseException : Exception
        {
            public DataBaseException()
            {
            }

            public DataBaseException(string? message) : base(message)
            {
            }

            public DataBaseException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected DataBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}







