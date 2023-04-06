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

        public string nev { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Ora>? orakColl { get; set; } //hozzá tartozó órák
        
        public override string PasswordHash
        {
            get => base.PasswordHash; 
            set
            {

                PasswordHasher<Tanar> ph = new PasswordHasher<Tanar>();
                base.PasswordHash = ph.HashPassword(this, value);
            }
        }

        

        [Required]
        public override string Email
        {
            get => base.Email; 
            set
            {
                base.Email = EkezetEltavolitas(value);
                base.UserName = base.Email;
                base.NormalizedEmail = base.Email.ToUpper();
                base.NormalizedUserName = base.NormalizedEmail;
                    
            }
        }

        

        public Tanar()
        {
            
            orakColl = new HashSet<Ora>();
            
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
