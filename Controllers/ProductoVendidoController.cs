using AppSistemaVentas.ADO.NET;
using Microsoft.AspNetCore.Mvc;

namespace AppSistemaVentas.Controllers
{
    public class ProductoVendidoController : Controller
    {
        ADO_ProductosVendidos _productVendi = new ADO_ProductosVendidos();
        public IActionResult Listar_Producto_Vendido()
        {
            var listVent = _productVendi.ListarProductoVendido();
            return View(listVent);
        }
    }
}
