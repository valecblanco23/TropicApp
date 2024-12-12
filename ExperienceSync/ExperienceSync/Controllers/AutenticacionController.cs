using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class AutenticacionController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult RecuperarPassword()
        {
            return View();
        }
    }
}
