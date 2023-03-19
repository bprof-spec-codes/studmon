using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Ora
    {
        [Key]
        public string Id { get; set; }
        public string nev { get; set; }
        public string leiras { get; set; }

        public Terem terem { get; set; }

        public Tanar tanar { get; set; }

        public int alkalmakSzama { get; set; }

        public DateTime oraKezdet { get; set; }

        public DateTime oraVeg { get; set; }

        
        public List<Hallgato> hallgatokColl { get; set; }

        //[NotMapped]
        //public string[,] ulesRend  { get; set; } //ugyan akkora mátrix mint a terem, NEPTUN kódok a megfelelő helyre beírva

        public string ulesRend { get; set; } //ugyan akkora mátrix mint a terem, NEPTUN kódok a megfelelő helyre beírva szóközzel elválasztva, új sor ","

        public Ora()
        {
            
        }

        public Ora(string nev, string leiras, Terem terem, Tanar tanar, int alkalmakSzama, DateTime oraKezdet, DateTime oraVeg, string ulesRend)
        {
            this.Id = Guid.NewGuid().ToString();
            this.nev = nev;
            this.leiras = leiras;
            this.terem = terem;
            this.tanar = tanar;
            this.alkalmakSzama = alkalmakSzama;
            this.oraKezdet = oraKezdet;
            this.oraVeg = oraVeg;
            this.hallgatokColl = new List<Hallgato>();
            this.ulesRend = ulesRend;
        }
    }
}
