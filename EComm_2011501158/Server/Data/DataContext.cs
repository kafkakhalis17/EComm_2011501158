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
                 Harga = 70000,
                 HargaOrginal = 120.000m,
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
                 Harga = 70000,
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
            base.OnModelCreating(modelBuilder);
        }

    }
}
