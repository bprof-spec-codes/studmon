namespace studmon.Models
{
    public class Tanar
    {
        public string neptunKod { get; set; }

        public string nev { get; set; }

        public virtual ICollection<Ora> orakColl { get; set; }

        public Tanar(string neptunKod, string nev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.orakColl = new HashSet<Ora>();
        }
    }
}
