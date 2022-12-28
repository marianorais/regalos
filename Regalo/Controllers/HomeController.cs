using Microsoft.AspNetCore.Mvc;
using Regalo.Models;
using System.Diagnostics;

namespace Regalo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }
        public IActionResult AllPages()
        {
            return View();
        }
        public IActionResult AllPagesDesktop()
        {
            return View();
        }
        public IActionResult Page24()
        {
            return View();
        }
        public IActionResult Page17()
        {
            return View();
        }
        public IActionResult PageTest()
        {
            return View();
        }
        public IActionResult ConfirmarFoto()
        {
            return View();
        }
        public IActionResult Page14()
        {
            return View();
        }
        public IActionResult Page11()
        {
            return View();
        }
        public IActionResult Page26()
        {
            return View();
        }
        public IActionResult Page20()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page9()
        {
            return View();
        }

        public IActionResult Page4()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}