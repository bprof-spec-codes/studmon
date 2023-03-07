namespace studmon.Models
{
    public class Teljesitmeny
    {
        public Ora ora { get; set; }

        public int[] ertekelesek { get; set; }

        public Teljesitmeny(Ora ora)
        {
            this.ora = ora;
            this.ertekelesek = new int [14];
        }
    }
}
