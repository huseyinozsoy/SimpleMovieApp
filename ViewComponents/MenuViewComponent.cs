using Microsoft.AspNetCore.Mvc;
using SimpleMovieApp.Models;

namespace SimpleMovieApp.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(){
            MovieContext context = new MovieContext();
            var categories = context.Categories;
            return View(categories);
            
        }
    }
}