namespace studmonBackend.Data.Models
{
    public class RegisterViewModel
    {
        private string Id;
        public string nev { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        //public string NeptunKodGenerator()
        //{

        //    Random random = new Random();

        //    string neptunkod = "";
           
        //        neptunkod = "";
        //        for (int i = 0; i < 6; i++)
        //        {
        //            if (random.NextDouble() < 0.5)
        //            {
        //                neptunkod += (char)random.Next('0', '9');
        //            }
        //            else
        //            {
        //                neptunkod += (char)random.Next('A', 'Z');
        //            }
        //        }
           

        //    return neptunkod.ToUpper();
        //}
    }
}
