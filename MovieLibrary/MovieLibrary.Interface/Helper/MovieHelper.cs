using MovieLibrary.Infrastructure.Models;
using MovieLibrary.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Helper
{
    public class MovieHelper
    {
        public IMovieService _movieService;
        public MovieHelper(IMovieService service)
        {
            _movieService = service;
        }

        public bool MovieExists(Movie movie)
        {
            var movieFromDb = _movieService.GetMovie(movie.Id);
            return movie == movieFromDb;
        }
    }

    public class MovieHelper2
    {
        public static bool MovieExists(Guid id)
        {

            return true;
        }
    }
}
