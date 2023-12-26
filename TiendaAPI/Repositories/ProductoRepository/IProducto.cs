using TiendaAPI.Entities;

namespace TiendaAPI.Repositories.ProductoRepository
{
    public interface IProducto
    {
        Task<List<Producto>> ConsultarTodos();

        Task<Producto> InsertarProducto(Producto producto);
    }
}
