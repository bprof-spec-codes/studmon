using Microsoft.AspNetCore.Identity;
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

        public Tanar(string neptunKod, string nev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.orakColl = new HashSet<Ora>();
        }
    }
}
