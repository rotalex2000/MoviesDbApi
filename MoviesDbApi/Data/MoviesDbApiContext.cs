using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesDbApi.Models;

namespace MoviesDbApi.Data
{
    public class MoviesDbApiContext : DbContext
    {
        public MoviesDbApiContext (DbContextOptions<MoviesDbApiContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesDbApi.Models.Movie> Movie { get; set; }
    }
}
