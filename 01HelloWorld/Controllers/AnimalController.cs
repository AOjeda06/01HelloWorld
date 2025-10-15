using Microsoft.AspNetCore.Mvc;

namespace _01HelloWorld.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gato()
        {
            return View();
        }
        public IActionResult ListadoAnimales()
        {
            return View();
        }

    }
}
