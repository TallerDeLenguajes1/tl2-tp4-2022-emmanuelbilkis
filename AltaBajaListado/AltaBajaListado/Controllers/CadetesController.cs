using Microsoft.AspNetCore.Mvc;
using AltaBajaListado.Models;

namespace AltaBajaListado.Controllers
{
    public class CadetesController:Controller
    {
        public IActionResult AltaCadete()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AltaCadete(Cadete cadete)
        {
            return View();
        }
    }
}
