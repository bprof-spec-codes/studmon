using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace studmonBackend.Data.Models
{
    public class Teljesitmeny
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teljesitmenyID { get; set; }



        [Required]
        [ForeignKey(nameof(Hallgato.neptunKod))]
        public string hallgatoNeptunKod { get; set; }

        [NotMapped]
        [JsonIgnore]
        
        public virtual Hallgato? hallgato { get; set; }

        [Required]
        [ForeignKey(nameof(Ora.Id))]
        public string oraId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual Ora? ora { get; set; } //melyik órához tartozó értékelések

        
        public int ertekeles { get; set; } //1 diákhoz tartozó értékelések

        //------------------------------------------
        
        
        //------------------------------------------

        public Teljesitmeny()
        { 
            
        }

        //public Teljesitmeny(string hallgatoNeptunKod, string oraId)
        //{
        //    this.ertekelesek = new int [14];
        //    this.hallgatoNeptunKod = hallgatoNeptunKod;
        //    this.oraId = oraId;
        //}
    }
}
