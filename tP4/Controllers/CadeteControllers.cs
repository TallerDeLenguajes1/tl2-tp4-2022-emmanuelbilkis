using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tP4.Models;
using SQLitePCL;
using Microsoft.Data.Sqlite;

namespace tP4.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Alta()
        {
            Cadete nuevo = new Cadete("Jeremias","Saavedra 454",34234,111,56000);
            return View(nuevo);
        }

        public IActionResult Baja()
        {
            Cadete nuevo = new Cadete("Jeremias", "Saavedra 454", 34234, 111, 56000);
            Cadete nuevo2 = new Cadete("Lucas", "Juan B Justo 1023", 3222, 112, 56400);
            Cadete nuevo3 = new Cadete("Florencia", "Marcos Paz 691", 31111, 113, 56200);

            List<Cadete> lista = new List<Cadete>();
            lista.Add(nuevo);
            lista.Add(nuevo2);
            lista.Add(nuevo3);

            Cadeteria Cadeteria456 = new Cadeteria("Cadeteria456", "San Juan 675", lista);
            return View(Cadeteria456);
        }

        public IActionResult ListadoCadete()
        {
            Cadete nuevo = new Cadete("Jeremias", "Saavedra 454", 34234, 111, 56000);
            Cadete nuevo2 = new Cadete("Lucas", "Juan B Justo 1023", 3222, 112, 56400);
            Cadete nuevo3 = new Cadete("Florencia", "Marcos Paz 691", 31111, 113, 56200);

            List<Cadete> lista = new List<Cadete>();
            lista.Add(nuevo);
            lista.Add(nuevo2);
            lista.Add(nuevo3);

            Cadeteria Cadeteria456 = new Cadeteria("Cadeteria456","San Juan 675",lista);
            return View(Cadeteria456);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AltaBD()
        {
            string dirBD = @"C:\Users\emman\source\repos\tP4\tP4\BD\Cadetes.db";
            using (var connection = new SqliteConnection(dirBD))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return View(reader);
                        }
                    }
                    connection.Close();
                }
            }
            return View();
        }
    }
}