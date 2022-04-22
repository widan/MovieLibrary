using MovieLibrary.Core.ModelsDTO;
using MovieLibrary.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Services
{
    public interface IMovieService //: IService
    {
        public IQueryable<Movie> GetAllMovies();
        public Movie GetMovie(Guid id);


    }
}
