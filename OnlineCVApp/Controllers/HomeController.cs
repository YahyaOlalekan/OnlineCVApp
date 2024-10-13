using Microsoft.AspNetCore.Mvc;
using OnlineCVApp.Models;
using System.Diagnostics;

namespace OnlineCVApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index() => View();
        public IActionResult AboutMe() => View();
        public IActionResult Portfolio() => View();
        public IActionResult Contact() => View();
        public IActionResult Resume() => View(); // Resume/CV Page


                     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
