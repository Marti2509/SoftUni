using DemoASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPNET.Controllers
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
            ViewBag.Message = "Home page";
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.Message = "This is the ASP.NET Core MVC Demo app.";
            ViewBag.Creator = "Martin Simov";
            return View();
        }

        public IActionResult Numbers1To50()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NumbersToN()
        {
            ViewBag.Count = 3;
            return View();
        }

        [HttpPost]
        public IActionResult NumbersToN(int count = 3)
        {
            ViewBag.Count = count;
            return View();
        }

        [Route("Privacy")]
        public IActionResult Privacy()
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