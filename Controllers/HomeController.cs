using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using University.Models;

namespace University.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult draw_table()
        { 
           return View();
        }
        public ActionResult change_image()
        {
            return View();
        }
        public ActionResult changeBackgroundColor()
        {
            return View();
        }
        public ActionResult calculator() 
        {
            return View(); 
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SemanticsAndDiv()
        {
            return View();
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
    }
}
