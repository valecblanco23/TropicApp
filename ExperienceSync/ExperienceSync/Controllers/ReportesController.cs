using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class ReportesController : Controller
    {
        [HttpGet]
        public IActionResult Reportes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Graficos()
        {
            return View();
        }
    }
}
