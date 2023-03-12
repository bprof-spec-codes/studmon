using Microsoft.AspNetCore.Identity;
using studmon.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Tanar : IdentityUser
    {
        [Key]
        public string neptunKod { get; set; }

        public string nev { get; set; }

        [NotMapped]
        public virtual ICollection<Ora> orakColl { get; set; } //hozzá tartozó órák

        public Tanar()
        {

        }

        //public Tanar(ApplicationDbContext dbContext)
        //{
        //    //this.neptunKod = dbContext.NeptunKodGenerator(dbContext.tanarTabla.ToList(), dbContext.hallgatoTabla.ToList());
        //}

        public Tanar(string neptunKod, string nev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.orakColl = new HashSet<Ora>();
            PasswordHasher<Tanar> ph = new PasswordHasher<Tanar>();
            this.PasswordHash = ph.HashPassword(this, "asdasd");
            this.Email = $"{nev.Split(' ')[0]}.{nev.Split(' ')[1]}@gmail.com".ToLower();
            this.NormalizedEmail = ($"{nev.Split(' ')[0]}.{nev.Split(' ')[1]}@gmail.com").ToUpper();
            this.UserName = Email;
            this.NormalizedUserName = NormalizedEmail;
        }
    }
}
