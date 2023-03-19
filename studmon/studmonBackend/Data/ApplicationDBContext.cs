//using studmonBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studmon.Models;


namespace studmonBackend.Data
{
    public class ApplicationDBContext : IdentityDbContext<Tanar>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opt) : base(opt)
        {

        }

        public DbSet<Hallgato> Hallgatok { get; set; }
        public DbSet<Ora> Orak { get; set; }
        public DbSet<Terem> Termek { get; set; }
        public DbSet<Tanar> Tanarok { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
            new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
        }
    }
}
