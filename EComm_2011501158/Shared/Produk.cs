    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

namespace EComm_2011501158.Shared
{
    public class Produk
    {
        [Key]
        public int IdProduk { get; set; }
        [Required(ErrorMessage ="Nama Harus Diisi")]
        public string Nama { get; set; } = string.Empty;
        [Required(ErrorMessage = "Deskripsi Harus Diisi")]
        public string Deskripsi { get; set; } = string.Empty;
        [Required(ErrorMessage = "Gamabar Harus Diisi")]

        public string GambarUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = "Harga Harus Diisi")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Harga { get; set; }
        [Required(ErrorMessage = "Harga Original Harus Diisi")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal HargaOrginal { get; set; }
        [Required(ErrorMessage = "status Harus Diisi")]
        public bool IsPublic { get; set; }
        [Required(ErrorMessage = "Status Harus Diisi")]
        public bool IsDeleted { get; set; }
  
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        [ForeignKey(nameof(IdKategori))]
        public Kategori? Kategori { get; set; }
        [Required(ErrorMessage = "Kategori Harus Diisi")]
        public int IdKategori { get; set; }
        public List<ProdukVarian> ProdukVarians { get; set; } = new List<ProdukVarian>();
    }
}
