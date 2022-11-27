using Microsoft.AspNetCore.Mvc;
using AppSistemaVentas.ADO.NET;

namespace AppSistemaVentas.Controllers
{
    public class ProductoController : Controller
    {
        ADO_Producto _product = new ADO_Producto();
        public IActionResult Listar_Producto()
        {
            var productList = _product.ListarProducto();
            return View(productList);
        }
    }
}
