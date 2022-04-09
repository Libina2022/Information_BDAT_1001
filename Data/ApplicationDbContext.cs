using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager_BDAT1001.Models;

namespace ContactManager_BDAT1001.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ContactManager_BDAT1001.Models.Contact> Contact { get; set; }
}
