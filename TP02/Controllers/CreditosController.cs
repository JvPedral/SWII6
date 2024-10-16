using Microsoft.AspNetCore.Mvc;

// João Vitor Pedral do Nascimento CB3022391
// Rodrigo Braga Guimarães Brito CB3018105

namespace TP02.Controllers
{
    public class CreditosController : Controller
    {
        // GET: CreditosC
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
