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
                new Hallgato("FTG456", "Huba Árpád", "NIK", "Bprof"),
                new Hallgato("KJGL45", "Török Levente", "NIK", "Bsc"),
                new Hallgato("ERF456", "Nyári Dalma", "NIK", "Bsc")
            };

            tanarLista = new List<Tanar>()
            {
                new Tanar()
                {
                    Id = "DFG234",
                    nev="Tóth Angéla",
                    PasswordHash= "asdasd",
                    Email="toth.angela@gmail.com"

                },
                new Tanar(){
                    Id = "QWE234",
                    nev="Balogh Attila",
                    PasswordHash= "asdasd",
                    Email="balogh.attila@gmail.com"

                },
                new Tanar(){
                    Id = "XY2345",
                    nev="Horváth Károly",
                    PasswordHash= "asdasd",
                    Email="horvat.karoly@gmail.com"
                },
            };

            List<Ora> oraLista = new List<Ora>()
            {
                new Ora()
                {
                    Id = "ASD123",
                    nev = "HFT",
                    leiras = "hft",
                    teremID = "BA 1.45",
                    tanarID = "XY2345",
                    alkalmakSzama = 12,
                    oraKezdet = DateTime.Now,
                    oraVeg = DateTime.Now.AddHours(1),
                    ulesRend = ""
                },

                new Ora()
                {
                    Id = "ASD234",
                    nev = "Dimat1",
                    leiras = "dimat1",
                    teremID = "BA 1.45",
                    tanarID = "QWE234",
                    alkalmakSzama = 13,
                    oraKezdet = DateTime.Now,
                    oraVeg = DateTime.Now.AddHours(1),
                    ulesRend = ""
                },

                new Ora()
                {
                    Id = "ASD345",
                    nev = "Vállgazd",
                    leiras = "hft",
                    teremID = "BA Audmax",
                    tanarID = "DFG234",
                    alkalmakSzama = 11,
                    oraKezdet = DateTime.Now,
                    oraVeg = DateTime.Now.AddHours(2),
                    ulesRend = ""
                }
            };

            List<Teljesitmeny> teljesitmenyLista = new List<Teljesitmeny>()
            {
                new Teljesitmeny
                {
                    hallgatoNeptunKod = "KJGL45",
                    oraId = "ASD345",
                    Ertekeles = new int []{1,0,0,1,-1,-1,0,1,1,1,1}
                },

                new Teljesitmeny
                {
                    hallgatoNeptunKod = "KJGL45",
                    oraId = "ASD234",
                    Ertekeles = new int []{1,1,1,0,1,-1,0,1,1,1,1}
                },

                new Teljesitmeny
                {
                    hallgatoNeptunKod = "FTG456",
                    oraId = "ASD234",
                    Ertekeles = new int []{0,0,0,0,1,-1,0,1,0,0,1}
                },
            };


            foreach (var item in tanarLista)
            {
                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = item.Id
                });
            }

            builder.Entity<Ora>().HasData(oraLista);
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

