using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class AracKategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Kategori { get; set; }
        public virtual ICollection<AracModel> AracModel { get; set; }
    }
}
//CREATE TABLE[dbo].[KATEGORI] (

//    [KATEGORIID][int] NOT NULL,

//    [KATEGORINAME] [nvarchar] (250) NULL,
//CREATE TABLE [dbo].[MARKA] (

//    [MARKAID][int] NOT NULL,

//    [MARKANAME] [nvarchar] (250) NULL,
//CREATE TABLE[dbo].[MARKAMODEL] (

//    [MODELID][int] NOT NULL,

//    [MARKAID] [int] NULL,
//	[MARKANAME][nvarchar] (250) NULL,

//    [MODELNAME] [nvarchar] (250) NULL,

//    [KATEGORIID] [int] NULL,
//	[KATEGORINAME][nvarchar] (250) NULL,

//    [DETAY] [nvarchar] (2000) NULL,

//CREATE TABLE [dbo].[MODEL] (

//    [MODELID][int] NOT NULL,

//    [MARKAID] [int] NULL,
//	[MODELNAME][nvarchar] (250) NULL,

//    [KATEGORI] [int] NULL,
//	[DETAY][nvarchar] (2000) NULL,