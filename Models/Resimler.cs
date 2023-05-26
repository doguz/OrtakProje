using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Resimler
    {
        [Key]
        public int Id { get; set; }
        public string ResimAdi { get; set; }
        public string? Aciklama { get; set; }
    }
}
