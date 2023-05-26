using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracKaza
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Aciklama { get; set; }
        [Required]
        public DateTime TarihSaat { get; set; }
        [Required]
        public int AracId { get; set; }
        [Required]
        public int PersonelSicil { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Personel Personel { get; set; }
    }
}