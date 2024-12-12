using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class CatalogoServiciosController : Controller
    {
        public IActionResult ListadoServicios()
        {
            return View();
        }
        public IActionResult AgregarServicio()
        {
            return View();
        }
    }
}
