using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
