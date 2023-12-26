using System;
using System.Collections.Generic;

namespace TiendaAPI.Entities
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Title { get; set; } = null!;
        public double Price { get; set; }
        public string Description { get; set; } = null!;
    }
}
