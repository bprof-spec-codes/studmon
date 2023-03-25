
using studmon.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmonBackend.Data.Models.ManyToManyModels
{
    public class OraManyToHallgatoMany
    {
        
        [Required]
        
        public string OraId { get; set; }
        [Required]
        
        public int HallgatoId { get; set; }

        public Ora? Ora { get; set; }

        public Hallgato? Hallgato { get; set; }

    }
}
