using aspTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspTutorial.Models;
using aspTutorial.ViewModels;

namespace aspTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Test" };

            var customers = new List<Customer>
            {
                new Customer{Name="Customer 21"},
                new Customer{Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);




            //return Content("dassdas");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home",new {page = 1, sortBy = "name" });


        }

        public ActionResult Edit(int movieId)
        {
    
            //return View(movie);
            return Content("id=" + movieId);
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home",new {page = 1, sortBy = "name" });
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
    }
}