using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetChillflix.Models
{
    public class DotNetChillflixContext : DbContext
    {
        public DotNetChillflixContext (DbContextOptions<DotNetChillflixContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetChillflix.Models.Video> Video { get; set; }
    }
}
