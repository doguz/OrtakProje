using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DateOnlyTimeOnly;

namespace Proje.Models
{
    public class Arac
    {
        [Key]
        public int Id { get; set; }
        
        //[RegularExpression(@"[0-9]{2}[A-Z]{1,3}[0-9]{1,4}", ErrorMessage ="Geçerli plaka giriniz!")]
        //[Range(4,9,ErrorMessage ="Geçerli plaka giriniz")]
        [Required]
        [DisplayName("Resmi Plaka")]
        public string ResmiPlaka { get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? MuayeneTarihi { get; set; }
        
        public int? Kilometre { get; set; }
        public int? AracModelYili { get; set; }
        
        //[Column(TypeName ="nvarchar(50)")]
        //[DisplayName("Resim dosyası adı")]
        //public string? AracResmi { get; set; }
        
        public int? AracModelId { get; set; }
        public int? AracVitesTipiId { get; set; }
        public int? AracYakitId { get; set; }
        public int? AracAidiyetId { get; set; }
        public int? RenkId { get; set; }
        public string? Aciklama { get; set; }

        public virtual AracModel? AracModel { get; set; }
        public virtual AracVitesTipi? AracVitesTipi { get; set; }
        public virtual AracYakit? AracYakit { get; set; }
        public virtual AracAidiyet? AracAidiyet { get; set; }
        public virtual Renk? Renk { get; set; }

        public virtual ICollection<AracSivilPlaka>? AracSivilPlaka { get; set; }
        public virtual ICollection<AracBakim>? AracBakim { get; set; }
        public virtual ICollection<AracKaza>? AracKaza { get; set; }
        public virtual ICollection<AracZimmet>? AracZimmet { get; set; }
        
        [NotMapped]
        [DisplayName("Araç Fotoğrafı Ekleyin")]
        public IFormFile? AracResimDosyasi { get; set; }
    }
}
