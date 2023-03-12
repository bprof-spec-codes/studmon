using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Terem
    {
        public string nev { get; set; }

        [NotMapped]
        public bool[,] elrendezes { get; set; } //true ahol ülnek, false a folyosó

        public Terem()
        {

        }

        public Terem(string nev, int szel, int hossz)
        {
            this.nev = nev;
            this.elrendezes = new bool[szel,hossz];
        }
    }
}
