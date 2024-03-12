using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class MentalityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
