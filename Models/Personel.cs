using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    public class Personel
    {
        [Key] public int Sicil { get; set; }
        [Required] public string AdSoyad { get; set; }
        [Required] public bool Cinsiyet { get; set; }
        public int RutbeID { get; set; }
        public int BuroId { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Telefon { get; set; }

        public virtual Rutbe Rutbe { get; set; }
        public virtual Buro Buro { get; set; }
        public virtual ICollection<AracBakim> AracBakim { get; set; }
        public virtual ICollection<AracKaza> AracKaza { get; set; }
        public virtual ICollection<AracZimmet> AracZimmetTeslim { get; set; }
        public virtual ICollection<AracZimmet> AracZimmetTesellum { get; set; }
        public virtual ICollection<DemirbasZimmet> DemirbasZimmetTeslim { get; set; }
        public virtual ICollection<DemirbasZimmet> DemirbasZimmetTesellum { get; set; }

    }
}
