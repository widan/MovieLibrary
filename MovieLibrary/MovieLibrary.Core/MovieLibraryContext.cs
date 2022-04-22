using Microsoft.EntityFrameworkCore;
using MovieLibrary.Core.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Core
{
    public class MovieLibraryContext : DbContext
    {
        public MovieLibraryContext(DbContextOptions<MovieLibraryContext> options) : base(options)
        {

        }

        public DbSet<MovieDto> Movies { get; set; }

    }
}
