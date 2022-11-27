using Microsoft.AspNetCore.Mvc;

using AppSistemaVentas.ADO.NET;
using AppSistemaVentas.Models;

namespace AppSistemaVentas.Controllers
{

    public class UsuarioController : Controller
    {
        ADO_Usuario _usuario = new ADO_Usuario();

        [HttpGet]
        public IActionResult Listar()
        {
            var ListaUsuario = _usuario.listarUsuario();
            return View(ListaUsuario);
        }
    }
}
