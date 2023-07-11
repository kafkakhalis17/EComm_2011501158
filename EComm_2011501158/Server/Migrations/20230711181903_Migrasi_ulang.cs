using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class Migrasi_ulang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    IdKategori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.IdKategori);
                });

            migrationBuilder.CreateTable(
                name: "Pengguna",
                columns: table => new
                {
                    IdPengguna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KonfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlamatPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeleponPengguna = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FotoPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengguna", x => x.IdPengguna);
                });

            migrationBuilder.CreateTable(
                name: "Pesanan",
                columns: table => new
                {
                    IdPesanan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TglPesanan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesanan", x => x.IdPesanan);
                });

            migrationBuilder.CreateTable(
                name: "Varian",
                columns: table => new
                {
                    IdVarian = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varian", x => x.IdVarian);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    IdProduk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GambarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HargaOrginal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKategori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.IdProduk);
                    table.ForeignKey(
                        name: "FK_Produk_Kategori_IdKategori",
                        column: x => x.IdKategori,
                        principalTable: "Kategori",
                        principalColumn: "IdKategori",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KonfirmasiPesanan",
                columns: table => new
                {
                    IdKonfirmasi = table.Column<int>(type: "int", nullable: false),
                    IdPesanan = table.Column<int>(type: "int", nullable: false),
                    TglKonfirmasi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankTransfer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglTransfer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JumlahTransfer = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonfirmasiPesanan", x => new { x.IdPesanan, x.IdKonfirmasi });
                    table.ForeignKey(
                        name: "FK_KonfirmasiPesanan_Pesanan_IdPesanan",
                        column: x => x.IdPesanan,
                        principalTable: "Pesanan",
                        principalColumn: "IdPesanan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PesananProduk",
                columns: table => new
                {
                    IdPesanan = table.Column<int>(type: "int", nullable: false),
                    IdProduk = table.Column<int>(type: "int", nullable: false),
                    IdVarian = table.Column<int>(type: "int", nullable: false),
                    NamaProduk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaVarian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesananProduk", x => new { x.IdPesanan, x.IdProduk, x.IdVarian });
                    table.ForeignKey(
                        name: "FK_PesananProduk_Pesanan_IdPesanan",
                        column: x => x.IdPesanan,
                        principalTable: "Pesanan",
                        principalColumn: "IdPesanan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PesananProduk_Produk_IdProduk",
                        column: x => x.IdProduk,
                        principalTable: "Produk",
                        principalColumn: "IdProduk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PesananProduk_Varian_IdVarian",
                        column: x => x.IdVarian,
                        principalTable: "Varian",
                        principalColumn: "IdVarian",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdukVarian",
                columns: table => new
                {
                    IdProduk = table.Column<int>(type: "int", nullable: false),
                    IdVarian = table.Column<int>(type: "int", nullable: false),
                    HargaVarian = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HargaOriVarian = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdukVarian", x => new { x.IdProduk, x.IdVarian });
                    table.ForeignKey(
                        name: "FK_ProdukVarian_Produk_IdProduk",
                        column: x => x.IdProduk,
                        principalTable: "Produk",
                        principalColumn: "IdProduk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdukVarian_Varian_IdVarian",
                        column: x => x.IdVarian,
                        principalTable: "Varian",
                        principalColumn: "IdVarian",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "IdKategori", "Nama" },
                values: new object[,]
                {
                    { 1, "Gitar" },
                    { 2, "Bass" },
                    { 3, "Keyboard/Synth" }
                });

            migrationBuilder.InsertData(
                table: "Pengguna",
                columns: new[] { "IdPengguna", "Admin", "AlamatPengguna", "EmailPengguna", "FotoPengguna", "KonfirmPassword", "NamaPengguna", "Password", "Status", "TeleponPengguna", "TglLahir", "Username" },
                values: new object[,]
                {
                    { 1, true, "Jl. Budiyanto No.2 Jakarta", "Khaliskafka@mail.com", "https://i.pinimg.com/564x/b6/24/7a/b6247a4b03bc5a296ac7f694b6b72863.jpg", "admin123", "kafka khalis", "admin123", true, "08193818311", new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "kafka17" },
                    { 2, false, "Jl. Budiyanto No.2 Jakarta", "Khaliskafka@mail.com", "https://i.pinimg.com/564x/c2/3a/2b/c23a2bf30698cda8384dedf791ea274b.jpg", "pengguna123", "kafka khalis", "pengguna123", true, "08193818311", new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "pkafka" }
                });

            migrationBuilder.InsertData(
                table: "Varian",
                columns: new[] { "IdVarian", "Nama" },
                values: new object[,]
                {
                    { 1, "Custom /KW" },
                    { 2, "Original" },
                    { 3, "Special Edition Presitage" },
                    { 4, "Special Edition Singnature" }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "IdProduk", "DateCreated", "DateUpdated", "Deskripsi", "GambarUrl", "Harga", "HargaOrginal", "IdKategori", "IsDeleted", "IsPublic", "Nama" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5071), "Bawalah pengalaman bermain gitar metal Anda ke level berikutnya dengan Gitar Ibanez GRGR121DX. Didesain khusus untuk menghadirkan suara yang menghancurkan dan tampilan yang mengesankan, gitar ini menjadi pilihan terbaik bagi para pemain metal dan content creator.  novel yang bercerita tentang pembunuhan seorang pegawai Departemen Luar Dibungkus dalam warna hitam yang elegan, Gitar Ibanez GRGR121DX menawarkan estetika yang kuat dan tampilan yang tangguh. Dengan desain yang ergonomis, ini adalah gitar yang nyaman dipegang dan dapat dipakai selama berjam-jam bermain, sehingga memungkinkan Anda untuk fokus pada kreasi musik terbaik Anda.", "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcS8NOnBysRWmlIR7-yEwxETas9pzA5IbUAFOJ4ia0npOrXkKIb9IcVydA4abKB7FYcJb8Ujy04o15SCIznDRzK2T3Ja5hnMNQe0AszhmxaEh5XtupTr08_47Q&usqp=CAE", 3000.000m, 4500.000m, 1, false, true, "Ibanez Electric Guitar GRGR121DX-BKF" },
                    { 2, new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5075), "THadapi intensitas musik metal dengan kekuatan Gitar iGrg140wh C14. Dirancang dengan kombinasi sempurna antara keindahan dan kekuatan, gitar ini memberikan pengalaman bermain yang epik dan cocok untuk penggemar lagu-lagu metal. Gitar iGrg140wh C14 membanggakan kualitas kayu maple yang luar biasa. Kayu maple memberikan resonansi yang kaya dan tajam, menghasilkan suara yang cocok untuk lagu-lagu metal dengan karakteristik yang diperlukan untuk menciptakan riff berat dan solo yang menghancurkan. Apakah Anda sedang mencari suara yang melengking atau distorsi yang intens, gitar ini akan memberikan kejelasan dan kekuatan yang Anda butuhkan.\r\n\r\nDilengkapi dengan bridge original Ibanez, gitar ini menjamin pemindahan getaran Jadikan Gitar iGrg140wh C14 sebagai senjata pilihan Anda dalam menjelajahi genre metal. Dari suara yang kuat hingga kualitas kayu maple yang indah, gitar ini menggabungkan segala yang Anda butuhkan untuk menghasilkan musik metal yang menakjubkan. Siapkan diri Anda untuk menghancurkan panggung dengan performa yang tak terlupakan menggunakan gitar ini. ", "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcTxEW4dCpLuVrxm3TAjqfJ2DYoluvYJW8dJ6irolidEXAGcpgDlHXXIW50RWa5eeWHFeBZUNQBfgHrslBL4k2prIvaZdQIgdrcqwGgBccyl5HawmR-CondL&usqp=CAE", 6000.000m, 800.000m, 1, false, true, " Ibanez Electric Guitar Grg140wh C14" },
                    { 3, new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5079), "Dummy untuk Deskripsi Produk: Gitar Ibanez JEMJRL-WH Steve Vai Signature\r\n\r\nRasakan keajaiban gitar Steve Vai dengan Gitar Ibanez JEMJRL-WH Steve Vai Signature. Didesain khusus untuk menggambarkan gaya bermain dan inovasi musikal Steve Vai, gitar ini merupakan pilihan sempurna bagi para penggemar dan pemain gitar yang ingin menghadirkan suara dan estetika khasnya. Dengan warna putih yang memukau, Gitar Ibanez JEMJRL-WH memancarkan keanggunan dan keunikan. Dalam kombinasi dengan desain signature Steve Vai yang legendaris, gitar ini menunjukkan karakter yang tidak ada duanya di panggungGitar ini dilengkapi dengan fitur-fitur khusus yang membuatnya menjadi ciri khas Steve Vai. Dari neck berbentuk khas \"Wizard III\" yang memungkinkan permainan yang cepat dan presisi hingga tremolo bridge yang ikonik, gitar ini memungkinkan pemain untuk mengekspresikan diri mereka secara bebas dan kreatif. ", "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRMaB6M03vahg40u23jpU8rKfhF2wJBvArUEOtVQpPq-NKZ1l0wyWKqs7XUqlNkkSvtJJYJEQZKtKSLt-kkmepQPX4g-cvJBFPO-NCJqJVDyGHIHJwKJnlIrw&usqp=CAE", 9000.000m, 8600.000m, 1, false, true, "Ibanez JEMJRL-WH Steve Vai Signature" },
                    { 4, new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5083), "Hadiri panggung dengan kekuatan dan keandalan Gitar Yamaha TRBX174 Electric Bass. Dirancang untuk memenuhi kebutuhan para pemain bass yang mencari instrumen yang tangguh dan dapat diandalkan, gitar ini menawarkan suara yang luar biasa dan kenyamanan bermain yang tak tertandingi.", "https://id.yamaha.com/id/files/Image-Index_BBNE2_1080x1080_ac739522bc0daea2ea8fc4a55cd6c2cc.jpg?impolicy=resize&imwid=396&imhei=396", 6000.000m, 8600.000m, 2, false, true, "Yamaha TRBX174 Electric Bass " },
                    { 5, new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 7, 12, 1, 19, 3, 148, DateTimeKind.Local).AddTicks(5086), "Jelajahi dunia suara yang tak terbatas dengan Synth Korg, alat yang dirancang untuk memenuhi kebutuhan musisi kreatif dan produser modern. Menggabungkan kecanggihan teknologi dengan kualitas suara yang luar biasa, Synth Korg adalah kunci menuju eksplorasi musik yang tak terbatas.", "https://pusatsoundsystem.com/wp-content/uploads/Korg-Minilogue-XD-350x350.jpg", 12000.000m, 16000.000m, 3, false, true, "Yamaha TRBX174 Electric Bass " }
                });

            migrationBuilder.InsertData(
                table: "ProdukVarian",
                columns: new[] { "IdProduk", "IdVarian", "HargaOriVarian", "HargaVarian" },
                values: new object[,]
                {
                    { 1, 1, 1000.000m, 1200.000m },
                    { 1, 2, 3000.000m, 2100.000m },
                    { 2, 1, 1000.000m, 900.000m },
                    { 2, 2, 4200.000m, 3200.000m },
                    { 3, 1, 1200.000m, 2400.000m },
                    { 3, 4, 12400.000m, 13050.000m },
                    { 4, 1, 1000.000m, 2050.000m },
                    { 4, 2, 3060.000m, 3200.000m },
                    { 4, 4, 8360.000m, 7200.000m },
                    { 5, 2, 8600.000m, 6520.000m },
                    { 5, 3, 12600.000m, 10520.000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PesananProduk_IdProduk",
                table: "PesananProduk",
                column: "IdProduk");

            migrationBuilder.CreateIndex(
                name: "IX_PesananProduk_IdVarian",
                table: "PesananProduk",
                column: "IdVarian");

            migrationBuilder.CreateIndex(
                name: "IX_Produk_IdKategori",
                table: "Produk",
                column: "IdKategori");

            migrationBuilder.CreateIndex(
                name: "IX_ProdukVarian_IdVarian",
                table: "ProdukVarian",
                column: "IdVarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KonfirmasiPesanan");

            migrationBuilder.DropTable(
                name: "Pengguna");

            migrationBuilder.DropTable(
                name: "PesananProduk");

            migrationBuilder.DropTable(
                name: "ProdukVarian");

            migrationBuilder.DropTable(
                name: "Pesanan");

            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "Varian");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
