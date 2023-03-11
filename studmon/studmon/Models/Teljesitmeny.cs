namespace studmon.Models
{
    public class Teljesitmeny
    {
        public Ora ora { get; set; } //melyik órához tartozó értékelések

        public int[] ertekelesek { get; set; } //1 diákhoz tartozó értékelések

        public Teljesitmeny(Ora ora)
        {
            this.ora = ora;
            this.ertekelesek = new int [14];
        }
    }
}
