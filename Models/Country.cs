using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Country
    {
        [Key] 
        public int CountryId { get; set; }
        public string BinaryCode { get; set; }
        public string TripleCode { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}