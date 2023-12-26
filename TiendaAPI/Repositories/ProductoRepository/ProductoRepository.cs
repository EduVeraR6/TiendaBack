using TiendaAPI.Entities;

namespace TiendaAPI.Repositories.ProductoRepository
{
    public class ProductoRepository : IProducto
    {
          private readonly TiendaContext _context;

        public ProductoRepository(TiendaContext context)
        {
            _context = context;
        }



        public async Task<List<Producto>> ConsultarTodos()
        {
            if(_context.Productos == null)
            {
                return null;
            }

            List<Producto> productos = _context.Productos.ToList();

            return productos;
        }

        public async Task<Producto> InsertarProducto(Producto producto)
        {
            await _context.AddAsync(producto);               
            await _context.SaveChangesAsync();

            return producto;
        }
    }
}
