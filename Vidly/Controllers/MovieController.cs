using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            //var movies = new List<Movie>
            //{
            //    new Movie { Id = 1, Name = "Shrek" },
            //    new Movie { Id = 2, Name = "Star Wars" }
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movies = movies
            //};
            var movies = GetMovies();
            
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Star Wars" }
            };

            return movies;
        }
    }
}