using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.GetVenta();
        }
        [HttpGet("{id}")]
        public IActionResult GetVentasById(int id)
        {
            Venta venta = VentaBussiness.GetVentasById(id);
            return Ok(venta);
        }
        [HttpDelete(Name = "EliminarVenta")]
        public string Delete([FromBody] int id)
        {
            bool status = VentaBussiness.EliminarVenta(id);
            if (status)
            {
                return "Venta eliminada";
            }
            else
            {
                return "La venta no se elimino";
            }
        }
        [HttpPut(Name = "ModificarVenta")]
        public bool Put([FromBody] Venta venta)
        {
            return VentaBussiness.CambiarVenta(venta);
        }
        [HttpPost(Name = "AltaVenta")]
        public bool Post([FromBody] Venta venta)
        {
            return VentaBussiness.CrearNuevaVenta(venta);

        }
    }
}

    

