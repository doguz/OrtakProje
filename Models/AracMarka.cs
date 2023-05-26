using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracMarka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marka { get; set; }
        public virtual ICollection<AracModel> AracModel { get; set; }
    }
}
