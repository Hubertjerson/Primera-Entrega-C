using System.Numerics;

namespace AppSistemaVentas.Models
{
    public class ProductoVendidoModel
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
    }
}
