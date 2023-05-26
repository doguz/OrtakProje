using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    public class AracSivilPlaka
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public int AracId { get; set; }
        public string SivilPlaka { get; set; }
        [Required][NotMapped] 
        public DateOnly DegisimTarihi { get; set; }

        public virtual Arac Arac { get; set; }
    }
}
