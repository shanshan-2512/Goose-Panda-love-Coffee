#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Goose_Panda_Love_Coffee.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class SchoolDBContext : IdentityDbContext
{
    public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
        : base(options)
    {
    }

    public DbSet<Goose_Panda_Love_Coffee.Models.Student> Student { get; set; }

    public DbSet<Goose_Panda_Love_Coffee.Models.User> User { get; set; }
}
