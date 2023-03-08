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
        IQueryable<MovieEntity> GetAll();
        MovieEntity GetById(Guid id);
        void Create(MovieEntity MovieEntity);
        void Update(MovieEntity MovieEntity);
    }
}
