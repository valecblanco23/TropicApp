using Microsoft.AspNetCore.Mvc;

namespace ExperienceSync.Controllers
{
    public class GestionInformacionController : Controller
    {
        public IActionResult ListadoClientes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AgregarCliente()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListadoEmpleados()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AgregarEmpleado()
        {
            return View();
        }
    }
}
