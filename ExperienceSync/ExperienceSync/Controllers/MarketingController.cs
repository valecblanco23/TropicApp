using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class MarketingController : Controller
    {
        public IActionResult ProgramarEnvio()
        {
            return View();
        }

        public IActionResult HistorialEnvio()
        {
            return View();
        }
    }
}
