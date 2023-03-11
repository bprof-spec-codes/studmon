namespace studmon.Models
{
    public class Terem
    {
        public string nev { get; set; }

        public bool[,] elrendezes { get; set; } //true ahol ülnek, false a folyosó

        public Terem(string nev, int szel, int hossz)
        {
            this.nev = nev;
            this.elrendezes = new bool[szel,hossz];
        }
    }
}
