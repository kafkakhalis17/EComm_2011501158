namespace EComm_2011501158.Shared
{
    public class Produk
    {
        public int IdProduk { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Deskripsi { get; set; } = string.Empty;
        public string GambarUrl { get; set; } = string.Empty;
        public decimal Harga { get; set; }
        public decimal HargaOrginal { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IdKategori { get; set; } 
        public int IdVarian { get; set; }       
    }
}
