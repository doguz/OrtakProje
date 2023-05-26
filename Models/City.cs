using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string PlateNo { get; set; }
        public string PhoneCode { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Town> Town { get; set; }
    }
}
