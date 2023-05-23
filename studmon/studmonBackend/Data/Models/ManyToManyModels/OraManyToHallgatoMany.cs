
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmonBackend.Data.Models.ManyToManyModels
{
    public class OraManyToHallgatoMany
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string OraId { get; set; }
        
        
        public string HallgatoId { get; set; }

        public virtual Ora? Ora { get; set; }

        public virtual Hallgato? Hallgato { get; set; }

    }
}
