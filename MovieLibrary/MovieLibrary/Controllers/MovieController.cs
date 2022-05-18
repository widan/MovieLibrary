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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            movie.Id = Guid.NewGuid();
             _service.Create(movie);
            return View(movie);
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
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
