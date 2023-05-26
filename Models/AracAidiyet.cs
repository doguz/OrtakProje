using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracAidiyet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Aidiyet { get; set; }

        public virtual ICollection<Arac> Arac { get; set; }
    }
}
