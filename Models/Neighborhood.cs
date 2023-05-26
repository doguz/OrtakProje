using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Neighborhood
    {
        [Key]
        public int NeighborhoodID { get; set; }
        public int DistrictID { get; set; }
        public string NeighborhoodName { get; set; }
        public string ZipCode { get; set; }

        public virtual District District { get; set; }
    }
}