using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductoVendido()
        {
            return ProductoVendidoData.ObtenerProductosVendidos();
        }
        public static bool EliminarVendido(int id)
        {
            return ProductoVendidoData.BorrarProductoVendidoId(id);
        }

        public static bool CrearNuevoProducto(ProductoVendido venta)
        {
            return ProductoVendidoData.CrearProductoVendido(venta);
        }

        public static bool CambiarProdcutoVendido(ProductoVendido venta)
        {
            return ProductoVendidoData.ActualizarProductoVendido(venta);
        }

        public static Producto GetProductosVendidosById(int id)
        {
            return ProductoVendidoData.ObtenerProductosVendidos(id);
        }

    }
}

    

