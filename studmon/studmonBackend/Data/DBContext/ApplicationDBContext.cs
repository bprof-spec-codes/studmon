//using studmonBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studmonBackend.Data.Models;
using studmonBackend.Data.Models.ManyToManyModels;
using System.Reflection.Emit;

namespace studmonBackend.Data.DBContext
{
    public class ApplicationDBContext : IdentityDbContext<Tanar>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opt) : base(opt)
        {

        }
        private static Random rnd = new Random(); //Random neptunkód generáló

        private List<Tanar> tanarLista = new List<Tanar>();
        private List<Hallgato> hallgatoLista = new List<Hallgato>();
        private List<Terem> teremLista = new List<Terem>();


        public DbSet<Hallgato> Hallgatok { get; set; }
        public DbSet<Ora> Orak { get; set; }
        public DbSet<Terem> Termek { get; set; }
        public DbSet<Tanar> Tanarok { get; set; }
        public DbSet<Teljesitmeny> Teljesitmenyek { get; set; }

        //public DbSet<OraManyToHallgatoMany> OraHallgatoTabla { get; set; }

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
                .OnDelete(DeleteBehavior.Cascade)
                );


            //Many to Many

            builder.Entity<OraManyToHallgatoMany>(oh => oh
                .HasKey(oh => new { oh.OraId, oh.HallgatoId })
                );

            builder.Entity<OraManyToHallgatoMany>()
                .HasOne(oh => oh.Ora)
                .WithMany(o => o.hallgatokColl)
                .HasForeignKey(oh => oh.OraId);

            builder.Entity<OraManyToHallgatoMany>()
                .HasOne(oh => oh.Hallgato)
                .WithMany(h => h.orak)
                .HasForeignKey(oh => oh.HallgatoId);












            builder.Entity<IdentityRole>().HasData(
            new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new { Id = "2", Name = "Tanar", NormalizedName = "TANAR" }
            );

            teremLista = new List<Terem>()
            {
                new Terem("BA 1.45", "1110111,1110111,1110111,1110111"),
                new Terem("BA Audmax", "110111,110111,110111,110111"),
                new Terem("BA 1.21", "1110111,1110111,1110111,1110111")
            };

            hallgatoLista = new List<Hallgato>()
            {
                new Hallgato(NeptunKodGenerator(), "Huba Árpád", "NIK", "Bprof"),
                new Hallgato(NeptunKodGenerator(), "Török Levente", "NIK", "Bsc"),
                new Hallgato(NeptunKodGenerator(), "Nyári Dalma", "NIK", "Bsc")
            };

            tanarLista = new List<Tanar>()
            {
                new Tanar()
                {
                    Id = NeptunKodGenerator(),
                    nev="Tóth Angéla",
                    PasswordHash= "asdasd",
                    Email="toth.angela@gmail.com"

                },
                new Tanar(){
                    Id = NeptunKodGenerator(),
                    nev="Balogh Attila",
                    PasswordHash= "asdasd",
                    Email="balogh.attila@gmail.com"

                },
                new Tanar(){
                    Id = NeptunKodGenerator(),
                    nev="Horváth Károly",
                    PasswordHash= "asdasd",
                    Email="horvat.karoly@gmail.com"
                },
            };

            builder.Entity<Hallgato>().HasData(hallgatoLista);
            builder.Entity<Tanar>().HasData(tanarLista);
            builder.Entity<Terem>().HasData(teremLista);

            base.OnModelCreating(builder);
        }
        public string NeptunKodGenerator()
        {
            string neptunkod = "";
            while (neptunkod == "" || (0 <= tanarLista.FindIndex(index => index.Id == neptunkod) && 0 <= hallgatoLista.FindIndex(index => index.neptunKod == neptunkod)))
            {
                neptunkod = "";
                for (int i = 0; i < 6; i++)
                {
                    if (rnd.NextDouble() < 0.5)
                    {
                        neptunkod += (char)rnd.Next('0', '9');
                    }
                    else
                    {
                        neptunkod += (char)rnd.Next('A', 'Z');
                    }
                }
            }

            return neptunkod.ToUpper();
        }



    }
}

