using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Goose_Panda_Love_Coffee.Models;
using Microsoft.EntityFrameworkCore;



public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private readonly SchoolDBContext _context;
    [BindProperty]
    public User? UserInfo { get; set; }
    public IndexModel(ILogger<IndexModel> logger, SchoolDBContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        UserInfo = await _context.User.FirstOrDefaultAsync();
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (UserInfo != null)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserInfo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        _logger.Log(LogLevel.Information, UserInfo.Name);
        return RedirectToPage("../Index");
    }
}

