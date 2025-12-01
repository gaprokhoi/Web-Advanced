using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
