#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goose_Panda_Love_Coffee.Models;

namespace Goose_Panda_love_Coffee.Pages.Classes
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolDBContext _context;

        public DetailsModel(SchoolDBContext context)
        {
            _context = context;
        }

        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.Include(s => s.Enrolled).FirstOrDefaultAsync(m => m.classId == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
