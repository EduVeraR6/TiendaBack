using TiendaAPI.Entities;

namespace TiendaAPI.Services.ProductoServices
{
    public interface IProductoService
    {
        Task<List<Producto>> ConsultarTodos();
        Task<Producto> InsertarProducto(Producto producto);

        Task<Producto> UpdateProducto(Producto producto);
        Task<Producto> ConsultarPorId(int id);

    }
}
