using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //Action Results
        //Passing Data to Views
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };
            List<Customer> Customers = new List<Customer>
            {
                new Customer {Name= "Customer 1"},
                new Customer {Name= "Customer 2" }
            };

            RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers
            };

            return View(viewModel);
            #region Old Training Code

            //Passing Data to Views
            ////ViewData["Movie"] = movie;
            ////ViewBag.RandomMovie = movie;
            ////ToCheck///var viewResult = new ViewResult();
            ////ToCheck///viewResult.ViewData.Model


            //ActionResults
            ////return View(movie);
            ////return Content("Hello World");
            ////return HttpNotFound();
            ////return new EmptyResult();
            ////return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            #endregion
        }

        #region Old Training Code
        ////Action Parameters
        //public ActionResult Edit(int movieId)
        //{
        //    return Content("movieId=" + movieId);
        //}

        ////Action Parameters
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("Page Index = {0} " + System.Environment.NewLine + " Sort By = {1}", pageIndex, sortBy));
        //}

        ////Attribute Routing
        //[Route("movies/released/{year}/{month:regex(\\d{1,2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    //return View();
        //    return Content(year + "/" + month);
        //}
        #endregion
    }
}