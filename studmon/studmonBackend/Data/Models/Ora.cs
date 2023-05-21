using Newtonsoft.Json;
using studmonBackend.Data.Models.ManyToManyModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmonBackend.Data.Models
{
    public class Ora
    {
        [Key]
        public string Id { get; set; }
        public string nev { get; set; }
        public string leiras { get; set; }


        [NotMapped]
        [JsonIgnore]
        public virtual Terem? terem { get; set; }

        [ForeignKey(nameof(Terem.nev))]
        public string teremID { get; set; }


        [NotMapped]
        [JsonIgnore]
        public virtual Tanar? tanar { get; set; }

        [ForeignKey(nameof(Tanar.Id))]
        public string tanarID { get; set; }

        public int alkalmakSzama { get; set; }

        public DateTime oraKezdet { get; set; }

        public DateTime oraVeg { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<OraManyToHallgatoMany>? hallgatokColl { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Teljesitmeny>? teljesitmenyColl { get; set; }



        //[NotMapped]
        //public string[,] ulesRend  { get; set; } //ugyan akkora mátrix mint a terem, NEPTUN kódok a megfelelő helyre beírva

        public string ulesRend { get; set; } //ugyan akkora mátrix mint a terem, NEPTUN kódok a megfelelő helyre beírva szóközzel elválasztva, új sor ","

        public Ora()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public Ora(string nev, string leiras,string teremID, string tanarID, int alkalmakSzama, DateTime oraKezdet, DateTime oraVeg, string ulesRend)
        {
            this.Id = Guid.NewGuid().ToString();
            this.nev = nev;
            this.leiras = leiras;
            this.teremID = teremID;
            this.tanarID = tanarID;
            this.alkalmakSzama = alkalmakSzama;
            this.oraKezdet = oraKezdet;
            this.oraVeg = oraVeg;
            this.hallgatokColl = new HashSet<OraManyToHallgatoMany>();
            this.teljesitmenyColl = new HashSet<Teljesitmeny>();
            this.ulesRend = ulesRend;
        }
    }
}
