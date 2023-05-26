using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class District
    {
        [Key]
        public int DistrictID { get; set; }
        public int TownID { get; set; }
        public string DistrictName { get; set; }

        public virtual Town Town { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Neighborhood> Neighborhood { get; set; }
    }
}