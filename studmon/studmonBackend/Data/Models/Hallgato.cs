using studmonBackend.Data.Models.ManyToManyModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmonBackend.Data.Models
{
    public class Hallgato
    {
        [Key]
        public string neptunKod { get; set; }

        public string nev { get; set; }

        public string kar { get; set; } //pl.: NIK

        public string kepzesNev { get; set; } //pl.: Bprof, Bsc

        public virtual ICollection<OraManyToHallgatoMany>? orak { get; set; }

        
        public virtual ICollection<Teljesitmeny>? teljesitmeny { get; set; } //Órai teljesítmények

        public Hallgato(string neptunKod, string nev, string kar, string kepzesNev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.kar = kar;
            this.kepzesNev = kepzesNev;
            this.teljesitmeny = new HashSet<Teljesitmeny>();
            this.orak = new HashSet<OraManyToHallgatoMany>();
        }
    }
}
