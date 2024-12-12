using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class TableroController : Controller
    {
        public IActionResult TableroKanban()
        {
            return View();
        }
    }
}
