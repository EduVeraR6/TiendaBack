using TiendaAPI.Entities;
using TiendaAPI.Repositories.ProductoRepository;

namespace TiendaAPI.Services.ProductoServices
{
    public class ProductoService : IProductoService
    {

        private readonly IProducto _repository;

        public ProductoService(IProducto repository)
        {
            _repository = repository;
        }

        public async Task<Producto> ConsultarPorId(int id)
        {
            return await  _repository.ConsultarPorId(id);  
        }

        public async  Task<List<Producto>> ConsultarTodos()
        {
            return await _repository.ConsultarTodos();
        }

        public async Task<Producto> InsertarProducto(Producto producto)
        {
            return await _repository.InsertarProducto(producto);
        }

        public async Task<Producto> UpdateProducto(Producto producto)
        {
            return await _repository.ActualizarProducto(producto);
        }
    }
}
