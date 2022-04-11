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
    public class EditCreditModel : PageModel
    {
        private readonly SchoolDBContext _context;

        

        public EditCreditModel(SchoolDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentClasses StudentClass { get; set; }

        public async Task<IActionResult> OnGetAsync(int? studentid, int? courseid)
        {
            if (studentid == null && courseid == null)
            {
                return NotFound();
            }

            StudentClass = await _context.StudentClasses.Where(sc => sc.Classes.ClassesId == courseid && sc.Student.StudentId == studentid).FirstOrDefaultAsync();

            if (StudentClass == null)
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

            _context.Attach(StudentClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassesExists(StudentClass.StudentClassesId))
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
            return _context.Student.Any(e => e.StudentId == id);
        }
    }
}
