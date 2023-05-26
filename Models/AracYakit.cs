using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracYakit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Yakit { get; set; }

        public virtual ICollection<Arac> Arac { get; set; }
    }
}
