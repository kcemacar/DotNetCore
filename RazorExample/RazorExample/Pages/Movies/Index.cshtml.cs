using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorExample.Data;
using RazorExample.Models;

namespace RazorExample.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorExample.Data.RazorExampleContext _context;

        public IndexModel(RazorExample.Data.RazorExampleContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
