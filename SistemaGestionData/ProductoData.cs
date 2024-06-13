using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductoData
    {
        public static List<Producto> ObtenerProducto()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<Producto> productos = new List<Producto>();

                string query = "SELECT * FROM Producto";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.id = Convert.ToInt32(reader["id"]);
                    producto.precioVenta = Convert.ToInt32(reader["PrecioVenta"]);
                    producto.descripcion = reader["Descripciones"].ToString();
                    producto.costo = Convert.ToInt32(reader["Costo"]);
                    producto.stock = Convert.ToInt32(reader["Stock"]);
                    producto.idUsuario = Convert.ToInt32(reader["IdUsuario"]);

                    productos.Add(producto);
                }
                return productos;
            }
        }
        public static Producto? ObtenerProductoPorId(int id)
        {
            List<Producto> producto = ProductoData.ObtenerProducto();
            return producto.Find(u => u.id == id);
        }

        public static bool BorrarProductoPorId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Producto WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearProducto(Producto producto)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario) VALUES " +
                    "(@descripciones,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("descripciones", producto.descripcion);
                command.Parameters.AddWithValue("costo", producto.costo);
                command.Parameters.AddWithValue("precioVenta", producto.precioVenta);
                command.Parameters.AddWithValue("stock", producto.stock);
                command.Parameters.AddWithValue("idUsuario", producto.idUsuario);
                
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarProducto(Producto nuevoProducto)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE Producto SET Descripciones = @descripciones, Costo = @costo, PrecioVenta = @precioVenta, Stock = @stock, IdUsuario = @idUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoProducto.id);
                command.Parameters.AddWithValue("descripciones", nuevoProducto.descripcion);
                command.Parameters.AddWithValue("costo", nuevoProducto.costo);
                command.Parameters.AddWithValue("precioVenta", nuevoProducto.precioVenta);
                command.Parameters.AddWithValue("stock", nuevoProducto.stock);
                command.Parameters.AddWithValue("idUsuario", nuevoProducto.idUsuario);
                return command.ExecuteNonQuery() > 0;
            }
        }


        public static void BorrarProductoPorId(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
