using MessagePack;
using Microsoft.Build.Framework;


namespace Proje.Models
{
    public class Kayit
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        
        
    }
}