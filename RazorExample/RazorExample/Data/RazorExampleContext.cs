using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorExample.Models;

namespace RazorExample.Data
{
    public class RazorExampleContext : DbContext
    {
        public RazorExampleContext (DbContextOptions<RazorExampleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorExample.Models.Movie> Movie { get; set; }
    }
}
