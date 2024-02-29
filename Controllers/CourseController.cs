using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
