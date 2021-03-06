#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goose_Panda_Love_Coffee.Models;

namespace Goose_Panda_love_Coffee.Pages_Classes
{
    public class IndexModel : PageModel
    {
        private readonly SchoolDBContext _context;

        public IndexModel(SchoolDBContext context)
        {
            _context = context;
        }

        public IList<Classes> Classes { get;set; }

        public async Task OnGetAsync()
        {
            Classes = await _context.Classes.ToListAsync();
        }
    }
}
