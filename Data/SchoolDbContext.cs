using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Goose_Panda_love_Coffee.Data;

public class SchoolDbContext : IdentityDbContext
{
    public 
    SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }
}
