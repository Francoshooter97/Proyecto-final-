using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class VentaData
    {
        public static List<Venta> ObtenerVentas()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<Venta> ventas = new List<Venta>();
                string query = "SELECT * FROM Venta";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.id = Convert.ToInt32(reader["Id"]);
                    venta.comentarios = reader["Comentarios"].ToString();
                    venta.idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    ventas.Add(venta);
                }
                return ventas;
            }
        }


        public static Venta ObtenerVentaId(int id)
        {
            List<Venta> venta = VentaData.ObtenerVentas();
            return venta.Find(b => b.id == id);
        }

        public static bool BorrarVentaId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Venta WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearVenta(Venta venta)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Venta (Comentarios,IdUsuario) VALUES " +
                    "(@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("comentarios", venta.comentarios);
                command.Parameters.AddWithValue("idUsuario", venta.idUsuario);
                return command.ExecuteNonQuery() > 0;
            }
        }


        public static bool ActualizarVenta(Venta nuevaVenta)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE ProductoVendido SET Id = @id, Comentarios= @comentarios, IdUsuario = @idUsuario WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevaVenta.id);
                command.Parameters.AddWithValue("comentarios", nuevaVenta.comentarios);
                command.Parameters.AddWithValue("idUsuario", nuevaVenta.idUsuario);
                return command.ExecuteNonQuery() > 0;

            }

        }

        public static void BorrarVentaId(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public static void BorrarVentaId(Venta venta)
        {
            throw new NotImplementedException();
        }
    }



}


