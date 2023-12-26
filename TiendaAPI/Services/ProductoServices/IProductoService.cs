using TiendaAPI.Entities;

namespace TiendaAPI.Services.ProductoServices
{
    public interface IProductoService
    {
        Task<List<Producto>> ConsultarTodos();
        Task<Producto> InsertarProducto(Producto producto);
    }
}
