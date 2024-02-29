using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
