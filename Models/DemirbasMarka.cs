using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class DemirbasMarka
    {
        [Key]
        public int Id { get; set; }
        public string Marka { get; set; }

        public virtual ICollection<DemirbasModel> DemirbasModel { get; set; }
    }
}