using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class DemirbasModel
    {
        [Key] public int Id { get; set; }
        public string Model { get; set; }
        public int DemirbasMarkaId { get; set; }

        public virtual DemirbasMarka DemirbasMarka { get; set; }
        public virtual ICollection<Demirbas> Demirbas { get; set; }
    }
}