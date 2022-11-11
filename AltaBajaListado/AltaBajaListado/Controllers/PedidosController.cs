
using Microsoft.AspNetCore.Mvc;
using AltaBajaListado.Models;

namespace AltaBajaListado.Controllers
{
    public class PedidosController: Controller
    {
        public IActionResult AltaPedido()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AltaPedido(Pedido pedido)
        {
            return View();
        }
    }
}
