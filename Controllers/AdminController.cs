using Microsoft.AspNetCore.Mvc;

namespace SimpleMovieApp.Controllers
{
    public class AdminController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}