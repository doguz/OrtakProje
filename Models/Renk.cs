using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Renk
    {
        [Key] public int Id { get; set; }
        [Required] public string Rengi { get; set; }

        public virtual ICollection<Arac>? Arac { get; set; }
    }
}
