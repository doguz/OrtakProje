using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Buro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BuroAdi { get; set; }

        public virtual ICollection<Personel> Personel { get; set; }
    }
}
