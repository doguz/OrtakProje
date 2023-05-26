using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Demirbas
    {
        [Key] public int Id { get; set; }
        public int DemirbasModelId { get; set; }
        public int DemirbasCinsiId { get; set; }
        public string SeriNo { get; set; }
        public string Aciklama { get; set; }

        public virtual DemirbasModel DemirbasModel { get; set; }
        public virtual DemirbasCinsi DemirbasCinsi { get; set; }
        public virtual ICollection<DemirbasZimmet> DemirbasZimmet { get; set; }

    }
}
