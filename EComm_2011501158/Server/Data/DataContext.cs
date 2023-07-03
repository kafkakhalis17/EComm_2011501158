using Microsoft.Extensions.Options;

namespace EComm_2011501158.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {

        }
        public DbSet<Produk> Produk { get; set; }   
        public DbSet<Varian> Varian { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet <Pengguna> Pengguna { get; set; }
        public DbSet <ProdukVarian> ProdukVarian { get; set; }
        public DbSet <ItemKereta> PesananProduk { get; set; }
        public DbSet <Pesanan>  Pesanan { get; set; }   
        public DbSet <KonfirmasiPesanan> KonfirmasiPesanan { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produk>().HasData(

             new Produk
             {
                 IdProduk = 1,
                 IdKategori = 1,
                 Nama = "Misteri Tujuh Lonceng",
                 Deskripsi = "Misteri Tujuh Lonceng adalah sebuah " +
                "novel yang bercerita tentang pembunuhan seorang pegawai Departemen Luar " +
                "Negeri Inggris di sebuah pemondokan, yaitu Pemondokan Chimney. Setelah itu " +
                "terjadi juga pembunuhan terhadap seorang pria yang tidak lain adalah teman " +
                "orang yang terbunuh di pemondokan Chimney.",
                 GambarUrl =
                "https://upload.wikimedia.org/wikipedia/id/4/4c/The_Seven_Dials_Mystery_First_Edition_Cover_1929.jpg",
                 Harga = 99.999m,
                 HargaOrginal = 100.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
             },
             new Produk
             {
                 IdProduk = 2,
                 IdKategori = 2,
                 Nama = "Season of Storms",
                 Deskripsi = "The Witcher adalah rangkaian enam novel fantasi dan 15 cerita pendek  " +
                "yang ditulis oleh penulis Polandia Andrzej Sapkowski" +
                "Serial ini berputar di sekitar \"penyihir\" eponymous, Geralt of Rivia ",
                 GambarUrl =
                "https://upload.wikimedia.org/wikipedia/en/8/84/Season_of_Storms_Orion.jpg",
                 Harga = 70.000m,
                 HargaOrginal = 12.0000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
               
             },
             new Produk
             {
                 IdProduk = 3,
                 IdKategori = 2,
                 Nama = "Lord of the rings",
                 Deskripsi = "The Lord of the Rings adalah sebuah novel epik  " +
                " fantasi tinggi [a] oleh penulis dan sarjana Inggris J. R. R. Tolkien. " +
                "Bertempat di Middle-earth, ceritanya dimulai sebagai sekuel dari buku anak-anak Tolkien tahun 1937 The Hobbit, tetapi akhirnya berkembang menjadi karya yang jauh lebih besar. ",
                 GambarUrl =
                "https://upload.wikimedia.org/wikipedia/en/thumb/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif/220px-First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
                 Harga = 70.000m,
                 HargaOrginal = 120.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
             
             }

            );

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { IdKategori=1, Nama="Horror"},
                new Kategori { IdKategori=2, Nama="Drama"},
                new Kategori { IdKategori=3, Nama="fantasi"}
             );
            modelBuilder.Entity<Varian>().HasData(
             new Varian { IdVarian=1, Nama="Fisik"},
             new Varian { IdVarian=2, Nama="Digital"},
             new Varian { IdVarian=3, Nama="Special Edition"},
             new Varian { IdVarian=4, Nama="Special Edition + Author sign"}
           );


            modelBuilder.Entity<Pengguna>().HasData(
                new Pengguna { IdPengguna=1, Username="kafka17", NamaPengguna ="kafka khalis", Password="admin123", EmailPengguna="Khaliskafka@mail.com", TeleponPengguna="08193818311", AlamatPengguna="Jl. Budiyanto No.2 Jakarta", FotoPengguna= "https://i.pinimg.com/564x/b6/24/7a/b6247a4b03bc5a296ac7f694b6b72863.jpg", TglLahir = new DateTime(2015, 5, 29), Admin=true  }
            
             );
            
            modelBuilder.Entity<ProdukVarian>().HasKey(p => new { p.IdProduk, p.IdVarian });
            

            modelBuilder.Entity<ProdukVarian>().HasData(
                 new ProdukVarian { 
                    IdVarian = 1,
                    IdProduk=1,
                    HargaOriVarian=130.000m,
                    HargaVarian=120.000m
                },
                 new ProdukVarian
                 {
                     IdVarian = 2,
                     IdProduk = 1,
                     HargaOriVarian = 100.000m,
                     HargaVarian = 60.000m
                 },
                 new ProdukVarian
                 {
                       IdVarian = 3,
                       IdProduk = 1,
                       HargaOriVarian = 240.000m,
                       HargaVarian = 185.000m
                 
                 },
                 new ProdukVarian
                 {
                      IdVarian = 1,
                      IdProduk = 2,
                      HargaOriVarian = 120.000m,
                      HargaVarian = 100.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 2,
                     IdProduk = 2,
                     HargaOriVarian = 100.000m,
                     HargaVarian = 75.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 4,
                     IdProduk = 2,
                     HargaOriVarian = 360.000m,
                     HargaVarian = 320.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 1,
                     IdProduk = 3,
                     HargaOriVarian = 360.000m,
                     HargaVarian = 300.000m

                 },
                 new ProdukVarian
                 {
                       IdVarian = 3,
                       IdProduk = 3,
                       HargaOriVarian = 600.000m,
                       HargaVarian = 520.000m

                 }
             );
            modelBuilder.Entity<ItemKereta>().HasKey(p => new { p.IdPesanan, p.IdProduk, p.IdVarian });
           
            modelBuilder.Entity<KonfirmasiPesanan>().HasKey(p => new { p.IdPesanan, p.IdKonfirmasi });
            modelBuilder.Entity<KonfirmasiPesanan>().HasData(
                new KonfirmasiPesanan
                {
                   IdKonfirmasi =1,
                   TglKonfirmasi = DateTime.Now,
                   BankTransfer = "BCA",
                   TglTransfer = DateTime.Now,
                   JumlahTransfer = 0m,
                   IdPesanan = 1
                 },
                new KonfirmasiPesanan
                {
                    IdKonfirmasi = 2,
                    TglKonfirmasi = DateTime.Now,
                    BankTransfer = "BCA",
                    TglTransfer = DateTime.Now,
                    JumlahTransfer = 10000.00m,
                    IdPesanan = 1
                }

            );
            base.OnModelCreating(modelBuilder);
        }


    }
}
