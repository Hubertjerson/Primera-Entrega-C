using Microsoft.AspNetCore.Mvc;

namespace AppSistemaVentas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
