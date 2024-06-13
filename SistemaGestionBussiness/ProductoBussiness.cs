using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.ObtenerProducto();
        }
        public static bool CrearProductos(Producto producto)
        {
            return ProductoData.CrearProducto(producto);
        }

        public static bool EliminarProducto(int id)
        {
            return ProductoData.BorrarProductoPorId(id);
        }

        public static bool ModificarProducto(Producto producto)
        {
            return ProductoData.ActualizarProducto(producto);
        }


        public static Producto GetProductosById(int id)
        {
            return ProductoData.ObtenerProductoPorId(id);
        }
    }
}



