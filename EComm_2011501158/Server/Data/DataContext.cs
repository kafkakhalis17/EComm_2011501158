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

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { IdKategori = 1, Nama = "Gitar" },
                new Kategori { IdKategori = 2, Nama = "Bass" },
                new Kategori { IdKategori = 3, Nama = "Keyboard/Synth" }
             );
            modelBuilder.Entity<Varian>().HasData(
             new Varian { IdVarian = 1, Nama = "Custom /KW" },
             new Varian { IdVarian = 2, Nama = "Original" },
             new Varian { IdVarian = 3, Nama = "Special Edition Presitage" },
             new Varian { IdVarian = 4, Nama = "Special Edition Singnature" }
           );

            modelBuilder.Entity<Produk>().HasData(

             new Produk
             {
                 IdProduk = 1,
                 IdKategori = 1,
                 Nama = "Ibanez Electric Guitar GRGR121DX-BKF",
                 Deskripsi = "Bawalah pengalaman bermain gitar metal Anda ke level berikutnya dengan Gitar Ibanez GRGR121DX. Didesain khusus untuk menghadirkan suara yang menghancurkan dan tampilan yang mengesankan, gitar ini menjadi pilihan terbaik bagi para pemain metal dan content creator.  " +
                "novel yang bercerita tentang pembunuhan seorang pegawai Departemen Luar " +
                "Dibungkus dalam warna hitam yang elegan, Gitar Ibanez GRGR121DX menawarkan estetika yang kuat dan tampilan yang tangguh. Dengan desain yang ergonomis, ini adalah gitar yang nyaman dipegang dan dapat dipakai selama berjam-jam bermain, sehingga memungkinkan Anda untuk fokus pada kreasi musik terbaik Anda.",
                 GambarUrl =
                "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcS8NOnBysRWmlIR7-yEwxETas9pzA5IbUAFOJ4ia0npOrXkKIb9IcVydA4abKB7FYcJb8Ujy04o15SCIznDRzK2T3Ja5hnMNQe0AszhmxaEh5XtupTr08_47Q&usqp=CAE",
                 Harga = 3000.000m,
                 HargaOrginal = 4500.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
             },
             new Produk
             {
                 IdProduk = 2,
                 IdKategori = 1,
                 Nama = " Ibanez Electric Guitar Grg140wh C14",
                 Deskripsi = "THadapi intensitas musik metal dengan kekuatan Gitar iGrg140wh C14. Dirancang dengan kombinasi sempurna antara keindahan dan kekuatan, gitar ini memberikan pengalaman bermain yang epik dan cocok untuk penggemar lagu-lagu metal. " +
                "Gitar iGrg140wh C14 membanggakan kualitas kayu maple yang luar biasa. Kayu maple memberikan resonansi yang kaya dan tajam, menghasilkan suara yang cocok untuk lagu-lagu metal dengan karakteristik yang diperlukan untuk menciptakan riff berat dan solo yang menghancurkan. Apakah Anda sedang mencari suara yang melengking atau distorsi yang intens, gitar ini akan memberikan kejelasan dan kekuatan yang Anda butuhkan.\r\n\r\nDilengkapi dengan bridge original Ibanez, gitar ini menjamin pemindahan getaran " +
                "Jadikan Gitar iGrg140wh C14 sebagai senjata pilihan Anda dalam menjelajahi genre metal. Dari suara yang kuat hingga kualitas kayu maple yang indah, gitar ini menggabungkan segala yang Anda butuhkan untuk menghasilkan musik metal yang menakjubkan. Siapkan diri Anda untuk menghancurkan panggung dengan performa yang tak terlupakan menggunakan gitar ini. ",
                 GambarUrl =
                "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcTxEW4dCpLuVrxm3TAjqfJ2DYoluvYJW8dJ6irolidEXAGcpgDlHXXIW50RWa5eeWHFeBZUNQBfgHrslBL4k2prIvaZdQIgdrcqwGgBccyl5HawmR-CondL&usqp=CAE",
                 Harga = 6000.000m,
                 HargaOrginal = 800.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
               
             },
             new Produk
             {
                 IdProduk = 3,
                 IdKategori = 1,
                 Nama = "Ibanez JEMJRL-WH Steve Vai Signature",
                 Deskripsi = "Dummy untuk Deskripsi Produk: Gitar Ibanez JEMJRL-WH Steve Vai Signature\r\n\r\nRasakan keajaiban gitar Steve Vai dengan Gitar Ibanez JEMJRL-WH Steve Vai Signature. Didesain khusus untuk menggambarkan gaya bermain dan inovasi musikal Steve Vai, gitar ini merupakan pilihan sempurna bagi para penggemar dan pemain gitar yang ingin menghadirkan suara dan estetika khasnya." +
                " Dengan warna putih yang memukau, Gitar Ibanez JEMJRL-WH memancarkan keanggunan dan keunikan. Dalam kombinasi dengan desain signature Steve Vai yang legendaris, gitar ini menunjukkan karakter yang tidak ada duanya di panggung" +
                "Gitar ini dilengkapi dengan fitur-fitur khusus yang membuatnya menjadi ciri khas Steve Vai. Dari neck berbentuk khas \"Wizard III\" yang memungkinkan permainan yang cepat dan presisi hingga tremolo bridge yang ikonik, gitar ini memungkinkan pemain untuk mengekspresikan diri mereka secara bebas dan kreatif. ",
                 GambarUrl =
                "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRMaB6M03vahg40u23jpU8rKfhF2wJBvArUEOtVQpPq-NKZ1l0wyWKqs7XUqlNkkSvtJJYJEQZKtKSLt-kkmepQPX4g-cvJBFPO-NCJqJVDyGHIHJwKJnlIrw&usqp=CAE",
                 Harga = 9000.000m,
                 HargaOrginal = 8600.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true
             
             }, 
             new Produk
             {
                 IdProduk = 4,
                 IdKategori = 2,
                 Nama = "Yamaha TRBX174 Electric Bass ",
                 Deskripsi = "Hadiri panggung dengan kekuatan dan keandalan Gitar Yamaha TRBX174 Electric Bass. Dirancang untuk memenuhi kebutuhan para pemain bass yang mencari instrumen yang tangguh dan dapat diandalkan, gitar ini menawarkan suara yang luar biasa dan kenyamanan bermain yang tak tertandingi.",
                 GambarUrl = "https://id.yamaha.com/id/files/Image-Index_BBNE2_1080x1080_ac739522bc0daea2ea8fc4a55cd6c2cc.jpg?impolicy=resize&imwid=396&imhei=396",
                 Harga = 6000.000m,
                 HargaOrginal = 8600.000m,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 IsDeleted = false,
                 IsPublic = true

             },
              new Produk
              {
                  IdProduk = 5,
                  IdKategori = 3,
                  Nama = "Yamaha TRBX174 Electric Bass ",
                  Deskripsi = "Jelajahi dunia suara yang tak terbatas dengan Synth Korg, alat yang dirancang untuk memenuhi kebutuhan musisi kreatif dan produser modern. Menggabungkan kecanggihan teknologi dengan kualitas suara yang luar biasa, Synth Korg adalah kunci menuju eksplorasi musik yang tak terbatas.",
                  GambarUrl = "https://pusatsoundsystem.com/wp-content/uploads/Korg-Minilogue-XD-350x350.jpg", 
                  Harga = 12000.000m,
                  HargaOrginal = 16000.000m,
                  DateCreated = DateTime.Now,
                  DateUpdated = DateTime.Now,
                  IsDeleted = false,
                  IsPublic = true

              }

            );


            modelBuilder.Entity<Pengguna>().HasData(
                new Pengguna { 
                    IdPengguna=1, 
                    Username="kafka17", 
                    NamaPengguna ="kafka khalis", 
                    Password="admin123",
                    KonfirmPassword = "admin123",
                    EmailPengguna ="Khaliskafka@mail.com",
                    TeleponPengguna="08193818311", 
                    AlamatPengguna="Jl. Budiyanto No.2 Jakarta", 
                    FotoPengguna= "https://i.pinimg.com/564x/b6/24/7a/b6247a4b03bc5a296ac7f694b6b72863.jpg",
                    TglLahir = new DateTime(2015, 5, 29), 
                    Admin=true ,
                    Status = true,
                }, 
                new Pengguna
                {
                    IdPengguna = 2,
                    Username = "pkafka",
                    NamaPengguna = "kafka khalis",
                    Password = "pengguna123",
                    EmailPengguna = "Khaliskafka@mail.com",
                    TeleponPengguna = "08193818311",
                    KonfirmPassword = "pengguna123",
                    AlamatPengguna = "Jl. Budiyanto No.2 Jakarta",
                    FotoPengguna = "https://i.pinimg.com/564x/c2/3a/2b/c23a2bf30698cda8384dedf791ea274b.jpg",
                    TglLahir = new DateTime(2015, 5, 29),
                    Admin = false,
                    Status = true,
                }

             );
            
            modelBuilder.Entity<ProdukVarian>().HasKey(p => new { p.IdProduk, p.IdVarian });
            

            modelBuilder.Entity<ProdukVarian>().HasData(
                 new ProdukVarian { 
                    IdVarian = 1,
                    IdProduk=1,
                    HargaOriVarian=1000.000m,
                    HargaVarian=1200.000m
                },
                 new ProdukVarian
                 {
                     IdVarian = 2,
                     IdProduk = 1,
                     HargaOriVarian = 3000.000m,
                     HargaVarian = 2100.000m
                 },
                   new ProdukVarian
                   {
                       IdVarian = 1,
                       IdProduk = 2,
                       HargaOriVarian = 1000.000m,
                       HargaVarian = 900.000m
                   },
                    new ProdukVarian
                    {
                        IdVarian = 2,
                        IdProduk = 2,
                        HargaOriVarian = 4200.000m,
                        HargaVarian = 3200.000m
                    },
                 new ProdukVarian
                 {
                       IdVarian = 4,
                       IdProduk = 3,
                       HargaOriVarian = 12400.000m,
                       HargaVarian = 13050.000m
                 
                 },
                 new ProdukVarian
                 {
                      IdVarian = 1,
                      IdProduk = 3,
                      HargaOriVarian = 1200.000m,
                      HargaVarian = 2400.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 1,
                     IdProduk = 4,
                     HargaOriVarian = 1000.000m,
                     HargaVarian = 2050.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 2,
                     IdProduk = 4,
                     HargaOriVarian = 3060.000m,
                     HargaVarian = 3200.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 4,
                     IdProduk = 4,
                     HargaOriVarian = 8360.000m,
                     HargaVarian = 7200.000m

                 },
                 new ProdukVarian
                 {
                       IdVarian = 2,
                       IdProduk = 5,
                       HargaOriVarian =8600.000m,
                       HargaVarian = 6520.000m

                 },
                 new ProdukVarian
                 {
                     IdVarian = 3,
                     IdProduk = 5,
                     HargaOriVarian = 12600.000m,
                     HargaVarian = 10520.000m

                 }
             );
            modelBuilder.Entity<ItemKereta>().HasKey(p => new { p.IdPesanan, p.IdProduk, p.IdVarian });
           
            modelBuilder.Entity<KonfirmasiPesanan>().HasKey(p => new { p.IdPesanan, p.IdKonfirmasi });
            
            base.OnModelCreating(modelBuilder);
        }


    }
}
