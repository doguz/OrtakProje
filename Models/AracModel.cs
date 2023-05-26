using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public int AracMarkaId { get; set; }
        public int AracKategoriId { get; set; }
        public string? Detay { get; set; }

        public virtual AracMarka AracMarka { get; set; }
        public virtual AracKategori AracKategori { get; set; }
        public virtual ICollection<Arac> Arac { get; set; }
    }
}