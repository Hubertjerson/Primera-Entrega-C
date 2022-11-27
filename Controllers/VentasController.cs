using AppSistemaVentas.ADO.NET;
using Microsoft.AspNetCore.Mvc;

namespace AppSistemaVentas.Controllers
{
    public class VentasController : Controller
    {
        ADO_Ventas _ventas = new ADO_Ventas();
        public IActionResult Listar_Ventas()
        {
            var listVenta = _ventas.ventasLista();
            return View(listVenta);
        }
    }
}
