using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vet_website.Models;

namespace Vet_website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vet_website.Models.Owner> Owner { get; set; } = default!;
        public DbSet<Vet_website.Models.Pet> Pet { get; set; } = default!;
    }
}
