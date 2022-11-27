using System.Data.SqlTypes;

namespace AppSistemaVentas.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string? Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
    }
}
