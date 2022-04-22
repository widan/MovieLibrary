using MovieLibrary.Core.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Core.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        protected MovieLibraryContext _context;

        public MovieRepository(MovieLibraryContext context)
        {
            _context = context;
        }

        public IQueryable<MovieDto> GetAll()
        {
            var result = _context.Movies;
            return result;
        }

        public MovieDto GetById(Guid id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
