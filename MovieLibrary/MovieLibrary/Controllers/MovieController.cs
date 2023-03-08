using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibrary.Core;
using MovieLibrary.Infrastructure.Models;
using MovieLibrary.Infrastructure.Services;
using MovieLibrary.Models;
using MovieLibrary.Models.Movies;

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


        //GET: MovieController/Details/{id)
        public ActionResult Details(Guid id)
        {
            var movie = _service.GetMovie(id);
            return View(movie);
        }


        [HttpGet]
        public ActionResult Create()
        {
            Movie movie = new Movie()
            {
                Released = DateTime.Now
            };
            return View(movie);

        }


        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {

            }
            movie.Id = Guid.NewGuid();

            _service.Create(movie);
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //[HttpDelete]
        //public ActionResult Delete(int id)
        //{
        //    // delete student from the database whose id matches with specified id

        //    return RedirectToAction("Index");
        //}

        public IActionResult Edit(Guid id)
        {
            var movie = _service.GetMovie(id);

            return View(movie);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id,  Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(movie);
                    
                }
                catch (Exception ex)
                {
                    
                    throw;
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
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
