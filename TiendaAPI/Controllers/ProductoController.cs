using Microsoft.AspNetCore.Mvc;
using TiendaAPI.Entities;
using TiendaAPI.Services.ProductoServices;

namespace TiendaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductoService _service;

        public ProductoController(IProductoService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> ConsultarTodos()
        {
            List<Producto> productos = await _service.ConsultarTodos();


            return Ok(productos);
        }

        [HttpPost]

        public async Task<IActionResult> InsertarProducto([FromBody] Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.InsertarProducto(producto);


            return Ok(producto);
        }



    }
}
