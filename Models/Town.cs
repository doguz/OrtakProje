using Proje.Models;
using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Town
    {
        [Key]
        public int TownID { get; set; }
        public int CityID { get; set; }
        public string TownName { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}