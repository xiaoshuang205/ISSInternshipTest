using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EONRealityFinal.Data;
using EONRealityFinal.Models;

namespace EONRealityFinal.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly EONRealityFinal.Data.EONRealityFinalContext _context;

        public IndexModel(EONRealityFinal.Data.EONRealityFinalContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
