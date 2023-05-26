using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Rutbe
    {
        [Key]
        public int Id { get; set; }
        public string RutbeAd { get; set; }
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
