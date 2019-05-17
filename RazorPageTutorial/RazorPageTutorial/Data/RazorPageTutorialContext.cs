using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageTutorial.Models
{
    public class RazorPageTutorialContext : DbContext
    {
        public RazorPageTutorialContext (DbContextOptions<RazorPageTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageTutorial.Models.Movie> Movie { get; set; }
    }
}
