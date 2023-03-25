using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Teljesitmeny
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        [Required]
        [ForeignKey(nameof(Hallgato.neptunKod))]
        public string hallgatoNeptunKod { get; set; }

        public virtual Hallgato? hallgato { get; set; }

        [Required]
        [ForeignKey(nameof(Ora.Id))]
        public string oraId { get; set; }

        public virtual Ora? ora { get; set; } //melyik órához tartozó értékelések

        [NotMapped]
        public int[] ertekelesek { get; set; } //1 diákhoz tartozó értékelések

        public Teljesitmeny()
        {

        }

        public Teljesitmeny(Ora ora)
        {
            this.ora = ora;
            this.ertekelesek = new int [14];
        }
    }
}
