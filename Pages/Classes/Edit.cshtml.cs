#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Goose_Panda_Love_Coffee.Models;

namespace Goose_Panda_love_Coffee.Pages_Classes
{
    public class EditModel : PageModel
    {
        private readonly SchoolDBContext _context;

        public EditModel(SchoolDBContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Classes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassesExists(Classes.ClassesId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClassesExists(int id)
        {
            return _context.Classes.Any(e => e.ClassesId == id);
        }
    }
}
