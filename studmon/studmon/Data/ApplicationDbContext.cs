using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studmon.Models;

namespace studmon.Data
{
    public class ApplicationDbContext : IdentityDbContext<Tanar>
    {
        private static Random rnd = new Random(); //Random neptunkód generáló
        public DbSet<Tanar> tanarTabla { get; set; }
        public DbSet<Hallgato> hallgatoTabla { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        private List<Tanar> tanarLista = new List<Tanar>();
        private List<Hallgato> hallgatoLista = new List<Hallgato>();

        protected override void OnModelCreating(ModelBuilder builder)
        {

            hallgatoLista = new List<Hallgato>()
            {
                new Hallgato(NeptunKodGenerator(), "Huba Árpád", "NIK", "Bprof"),
                new Hallgato(NeptunKodGenerator(), "Török Levente", "NIK", "Bsc"),
                new Hallgato(NeptunKodGenerator(), "Nyári Dalma", "NIK", "Bsc")
            };

            tanarLista = new List<Tanar>()
            {
                new Tanar(NeptunKodGenerator(), "Tóth Angéla"),
                new Tanar(NeptunKodGenerator(), "Balogh Attila"),
                new Tanar(NeptunKodGenerator(), "Horváth Károly")
            };

            builder.Entity<Hallgato>().HasData(hallgatoLista);
            builder.Entity<Tanar>().HasData(tanarLista);

            base.OnModelCreating(builder);
        }

        private string NeptunKodGenerator()
        {
            string neptunkod = "";
            while (neptunkod == "" || (0 <= tanarLista.FindIndex(index => index.neptunKod == neptunkod) && 0 <= hallgatoLista.FindIndex(index => index.neptunKod == neptunkod)))
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