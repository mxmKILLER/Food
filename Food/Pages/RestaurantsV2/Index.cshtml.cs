using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Food.Core;
using Food.Data;

namespace Food.Pages.RestaurantsV2
{
    public class IndexModel : PageModel
    {
        private readonly Food.Data.FoodDbContext _context;

        public IndexModel(Food.Data.FoodDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
