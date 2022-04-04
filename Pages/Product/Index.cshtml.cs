#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNet_Lab3_Shanshan.Models;
using System.Security.Claims;

namespace _Net_Lab3_Shanshan.Pages_Product
{
    public class IndexModel : PageModel
    {
        private readonly StoreDBContext _context;

        public IndexModel(StoreDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public string? UserEmail { get; set; }
        public async Task OnGetAsync()
        {

            Product = await _context.Product.ToListAsync();

            if (User.Identity != null)

            {

                var claimsIdentity = (ClaimsIdentity)User.Identity;

                if (claimsIdentity.IsAuthenticated)

                {

                    var email = claimsIdentity.FindFirst(ClaimTypes.Email);

                    if (email != null)

                    {
                        UserEmail = email.Value;
                    }



                }
            }
        }
    }
}


