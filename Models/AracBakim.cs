using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    public class AracBakim
    {
        [Key] public int Id { get; set; }
        public int Kilometre { get; set;}
        [NotMapped] 
        public DateOnly BakimTarihi { get; set; }
        public string Aciklama { get; set; }
        [Required]
        public int AracId { get; set; }
        [Required]
        public int PersonelSicil { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Personel Personel { get; set; }
    }
}