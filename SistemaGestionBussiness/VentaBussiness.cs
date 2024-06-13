using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVenta()
        {
            return VentaData.ObtenerVentas();
        }
        public static bool EliminarVenta(int id)
        {
            return VentaData.BorrarVentaId(id);
        }

        public static bool CrearNuevaVenta(Venta venta)
        {
            return VentaData.CrearVenta(venta);
        }

        public static bool CambiarVenta(Venta venta)
        {
            return VentaData.ActualizarVenta(venta);
        }

        public static Venta GetVentasById(int id)
        {
            return VentaData.ObtenerVentaId(id);
        }
    }
}