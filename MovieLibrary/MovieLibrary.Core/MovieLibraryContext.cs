using Microsoft.EntityFrameworkCore;
using MovieLibrary.Core.Models;
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

        public DbSet<Movie> Movies { get; set; }

    }
}
