using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class Calendario : Controller
    {
        public IActionResult CalendarioTareas()
        {
            return View();
        }
        public IActionResult AgregarEvento()
        {
            return View();
        }
    }
}
