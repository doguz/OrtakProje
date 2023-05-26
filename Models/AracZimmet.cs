using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracZimmet
    {
        [Key] public int Id { get; set; }
        public int AracId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Aciklama { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Personel? AracTeslim { get; set; }
        public virtual Personel? AracTesellum { get; set; }

    }
}
