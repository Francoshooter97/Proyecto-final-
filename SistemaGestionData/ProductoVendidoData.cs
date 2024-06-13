using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                string query = "SELECT * FROM ProductoVendido";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductoVendido productoVendido = new ProductoVendido();
                    productoVendido.id = Convert.ToInt32(reader["Id"]);
                    productoVendido.stock = Convert.ToInt32(reader["Stock"]);
                    productoVendido.idProducto = Convert.ToInt32(reader["IdProducto"]);
                    productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);

                    productosVendidos.Add(productoVendido);
                }
                return productosVendidos;
            }
        }
        public static ProductoVendido? ObtenerProductoVendidoPorId(int id)
        {
            List<ProductoVendido> productoVendido = ProductoVendidoData.ObtenerProductosVendidos();
            return productoVendido.Find(u => u.id == id);
        }


        public static bool BorrarProductoVendidoId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM ProductoVendido WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO ProductoVendido (Stock,IdProducto,IdVenta) VALUES " +
                    "(@stock,@idProducto,@idVenta)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("stock", productoVendido.stock);
                command.Parameters.AddWithValue("idProducto", productoVendido.idProducto);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock, IdProducto = @idProducto, IdVenta = @idVenta WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoProductoVendido.id);
                command.Parameters.AddWithValue("stock", nuevoProductoVendido.stock);
                command.Parameters.AddWithValue("idProducto", nuevoProductoVendido.idProducto);
                command.Parameters.AddWithValue("idVenta", nuevoProductoVendido.IdVenta);
                return command.ExecuteNonQuery() > 0;

            }

        }

        public static void BorrarProductoVendidoId(ProductoVendido venta)
        {
            throw new NotImplementedException();
        }

        public static void CrearProductoVendido(Venta venta)
        {
            throw new NotImplementedException();
        }

        public static Producto ObtenerProductosVendidos(int id)
        {
            throw new NotImplementedException();
        }
    }
}


    



