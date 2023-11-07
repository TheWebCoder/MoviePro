using Microsoft.AspNetCore.Mvc;

namespace MoviePro.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
