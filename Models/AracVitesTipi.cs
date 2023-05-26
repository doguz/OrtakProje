using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracVitesTipi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Vites { get; set; }

        public virtual ICollection<Arac> Arac { get; set; }
    }
}
