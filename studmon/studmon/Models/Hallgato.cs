namespace studmon.Models
{
    public class Hallgato
    {
        public string neptunKod { get; set; }

        public string nev { get; set; }

        public string kar { get; set; } //pl.: NIK

        public string kepzesNev { get; set; } //pl.: Bprof, Bsc

        public List<Teljesitmeny> teljesitmeny { get; set; }

        public Hallgato(string neptunKod, string nev, string kar, string kepzesNev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.kar = kar;
            this.kepzesNev = kepzesNev;
            this.teljesitmeny = new List<Teljesitmeny>();
        }
    }
}
