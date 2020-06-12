using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SimpleMovieApp.Models;

namespace SimpleMovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*
            var Movies = new List<Movie>{
                new Movie{MovieName="Ford Vs Ferrari",Description="Ford ve Ferrari mücadelesi"},
                new Movie{MovieName="SpiderMan",Description="Örümcek Adam"},
                new Movie{MovieName="Iron Man I",Description="Demir Adam 1"},
                new Movie{MovieName="Iron Man II",Description="Demir Adam 2"}
            };
            using (MovieContext mc = new MovieContext())
            {
                mc.Movies.AddRange(Movies);
                mc.SaveChanges();
            }*/
            var context = new MovieContext();
            var MovieList = context.Movies.ToList();
            return View(MovieList);
        }
        public IActionResult Details(int id){
            var context = new MovieContext();
            List<Movie> movie = context.Movies.Where(i=>i.ID==id).ToList();
            int categoryID = movie.First().CategoryID;
            ViewBag.category = (from m in context.Movies join category in context.Categories on categoryID equals category.CategoryID
            select new{
                category.CategoryName
            }).First().CategoryName;
            

            return View(movie);
        }
        public IActionResult Category(int id)
        {
            var context = new MovieContext();
            List<Movie> movie = context.Movies.Where(i=>i.CategoryID==id).ToList();
            return View(movie);
        }
    }
}