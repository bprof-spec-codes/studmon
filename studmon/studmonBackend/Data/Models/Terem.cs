using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Terem
    {
        [Key]
        public string nev { get; set; }

        //[NotMapped]
        //public bool[,] elrendezes { get; set; } //true ahol ülnek, false a folyosó

        public string elrendezes { get; set; } //1 ahol ülnek, 0 a folyosó és "," az új sor

        public Terem()
        {

        }

        public Terem(string nev, int szel, int hossz)
        {
            this.nev = nev;
            //this.elrendezes = new bool[szel,hossz];
            this.elrendezes = "";
        }
    }
}
