using MovieLibrary.Core.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Core.Repositories
{
    public interface IMovieRepository
    {
        IQueryable<MovieDto> GetAll();
        MovieDto GetById(Guid id);
        void Create(MovieDto movieDto);
        void Update(MovieDto movieDto);
    }
}
