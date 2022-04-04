#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNet_Lab3_Shanshan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class StoreDBContext : IdentityDbContext
{
    public StoreDBContext(DbContextOptions<StoreDBContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
}
