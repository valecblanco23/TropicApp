using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class ControlUsuarioController : Controller
    {
        public IActionResult ListadoUsuarios()
        {
            return View();
        }
        public IActionResult AgregarUsuario()
        {
            return View();
        }
    }
}
