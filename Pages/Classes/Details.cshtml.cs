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
    public class DetailsModel : PageModel
    {
        private readonly SchoolDBContext _context;

        public DetailsModel(SchoolDBContext context)
        {
            _context = context;
        }


        public Classes Classes { get; set; }

        public StudentClasses StudentClass { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id, int? courseid, int? studentid)
        {
            if (id == null)
            {
                return NotFound();
            }


            Classes = await _context.Classes.Include(s => s.Enrolled).FirstOrDefaultAsync(m => m.ClassesId == id);
            StudentClass = await _context.StudentClasses.Where(sc => sc.Classes.ClassesId == courseid && sc.Student.StudentId == studentid).FirstOrDefaultAsync();
          

            if (Classes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
