//using studmonBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studmon.Models;
using System.Reflection.Emit;

namespace studmonBackend.Data.DBContext
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
        public DbSet<Teljesitmeny> Teljesitmenyek { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ora>(ora => ora
                .HasOne(ora => ora.terem)
                .WithMany(terem => terem.Orak)
                .OnDelete(DeleteBehavior.Cascade)
                );

            builder.Entity<Ora>(ora => ora
                .HasOne(ora => ora.tanar)
                .WithMany(tanar => tanar.orakColl)
                .OnDelete(DeleteBehavior.Cascade)
                );

            builder.Entity<Ora>(ora => ora
                .HasMany(ora => ora.teljesitmenyColl)
                .WithOne(teljesitmeny => teljesitmeny.ora)
                .OnDelete(DeleteBehavior.Cascade)
                );

            builder.Entity<Hallgato>(hallgato => hallgato
                .HasMany(hallgato => hallgato.teljesitmeny)
                .WithOne(teljesitmeny => teljesitmeny.hallgato)
                );



            builder.Entity<IdentityRole>().HasData(
            new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
            );



            base.OnModelCreating(builder);
        }
    }
}
