using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class DemirbasZimmet
    {
        [Key] public int Id { get; set; }
        public int DemirbasId { get; set; }
        public DateTime? Tarih { get; set; }
        public string Aciklama { get; set; }

        public virtual Demirbas Demirbas { get; set; }
        public virtual Personel DemirbasTeslim { get; set; }
        public virtual Personel DemirbasTesellum { get; set; }
    }
}