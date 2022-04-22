using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibrary.Core;
using MovieLibrary.Infrastructure.Models;
using MovieLibrary.Infrastructure.Services;
using MovieLibrary.Models;

namespace MovieLibrary.Controllers
{
    public class MovieController : Controller
    {
        public List<MovieViewModel> Movies { get; set; }

        private IMovieService _service { get; set; }

        public MovieController(IMovieService service)
        {
            _service = service;
        }


        // /[Controller]/[ActionName]/[Parameters]
        // GET: MovieController
        //[HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _service.GetAllMovies();

            return View(movies);
        }


        //GET: MovieController/Details/5
        public ActionResult Details(Guid id)
        {
            var movie = _service.GetMovie(id);
            return View(movie);
        }

        //// GET: MovieController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
