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

        public void Create(MovieDto movieDto)
        {
            _context.AddAsync(movieDto);
            _context.SaveChangesAsync();
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

        public void Update(MovieDto movieDto)
        {
            _context.Update(movieDto);
            _context.SaveChangesAsync();
        }
    }
}
