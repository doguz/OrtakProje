using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class DemirbasCinsi
    {
        [Key] public int Id { get; set; }
        public string Cinsi { get; set; }
        
        public virtual ICollection<Demirbas> Demirbas { get; set; }
    }
}