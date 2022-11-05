using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tp4.Models;

namespace Tp4.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListarCadetes()
        {

            Cadete Lautaro = new Cadete(1, "Lautaro", "Saavedra Lamas 952", "4535345");
            return View(Cadete);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
