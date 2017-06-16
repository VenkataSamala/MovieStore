using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        // GET: Movies/Random
        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies {Id = 1, Name = "Om Shanti Om"},
                new Movies {Id = 2, Name = "Kites"},
                new Movies {Id = 3, Name = "Rang de Basanti"}
            };

        }
    }
}