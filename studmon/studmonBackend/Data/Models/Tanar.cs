using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
//using studmonBackend.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace studmonBackend.Data.Models
{
    public class Tanar : IdentityUser
    {
        [Key]
        public string neptunKod { get; set; }

        public string nev { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Ora>? orakColl { get; set; } //hozzá tartozó órák


        public Tanar(string neptunKod, string nev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.orakColl = new HashSet<Ora>();
            this.Id = neptunKod;
            PasswordHasher<Tanar> ph = new PasswordHasher<Tanar>();
            this.PasswordHash = ph.HashPassword(this, "asdasd");
            this.Email = EkezetEltavolitas($"{nev.Split(' ')[0]}.{nev.Split(' ')[1]}@gmail.com".ToLower());
            this.NormalizedEmail = EkezetEltavolitas(($"{nev.Split(' ')[0]}.{nev.Split(' ')[1]}@gmail.com").ToUpper());
            this.UserName = Email;
            this.NormalizedUserName = NormalizedEmail;
        }



        private string EkezetEltavolitas(string szoveg) // Ékezet eltávolítása a megadott szövegből
        {
            string stFormD = szoveg.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stFormD.Length; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[i]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[i]);
                }
            }

            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }
    }
}
