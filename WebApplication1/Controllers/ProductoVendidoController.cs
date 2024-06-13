using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> ProductosVendidos()
        {
            return ProductoVendidoBussiness.GetProductoVendido();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductosVendidosById(int id)
        {
            Producto productovendido = ProductoVendidoBussiness.GetProductosVendidosById(id);
            return Ok(productovendido);
        }
        [HttpDelete(Name = "EliminarProductoVendido")]
        public string Delete([FromBody] int id)
        {
            bool status = ProductoVendidoBussiness.EliminarVendido(id);
            if (status)
            {
                return "Venta eliminada";
            }
            else
            {
                return "La venta no se elimino";
            }
        }
        [HttpPut(Name = "ModificarProductoVendido")]
        public bool Put([FromBody] ProductoVendido venta)
        {
            return ProductoVendidoBussiness.CambiarProdcutoVendido(venta);
        }
        [HttpPost(Name = "AltaProductoVendido")]
        public bool Post([FromBody] ProductoVendido productovendido)
        {
            return ProductoVendidoBussiness.CrearNuevoProducto(productovendido);
        }
    }
}

    

