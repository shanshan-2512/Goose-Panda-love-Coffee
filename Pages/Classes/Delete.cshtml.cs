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
    public class DeleteModel : PageModel
    {
        private readonly SchoolDBContext _context;

        public DeleteModel(SchoolDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Classes Classes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Classes = await _context.Classes.FirstOrDefaultAsync(m => m.ClassesId == id);

            if (Classes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Classes = await _context.Classes.FindAsync(id);

            if (Classes != null)
            {
                _context.Classes.Remove(Classes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
