using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComm_2011501158.Shared
{
    public class Produk
    {
        [Key]
        public int IdProduk { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Deskripsi { get; set; } = string.Empty;
        public string GambarUrl { get; set; } = string.Empty;
        [Column(TypeName ="decimal(0,2)")]
        public decimal Harga { get; set; }
        [Column(TypeName = "decimal(0,2)")]
        public decimal HargaOrginal { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        [ForeignKey(nameof(IdKategori))]
        public Kategori? Kategori { get; set; } 
        public int IdKategori { get; set; }
       
    }
}
