using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class MigrasiAwal : Migration
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

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "IdKategori", "Nama" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Drama" },
                    { 3, "fantasi" }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "IdProduk", "DateCreated", "DateUpdated", "Deskripsi", "GambarUrl", "Harga", "HargaOrginal", "IdKategori", "IsDeleted", "IsPublic", "Nama" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1412), "Misteri Tujuh Lonceng adalah sebuah novel yang bercerita tentang pembunuhan seorang pegawai Departemen Luar Negeri Inggris di sebuah pemondokan, yaitu Pemondokan Chimney. Setelah itu terjadi juga pembunuhan terhadap seorang pria yang tidak lain adalah teman orang yang terbunuh di pemondokan Chimney.", "https://upload.wikimedia.org/wikipedia/id/4/4c/The_Seven_Dials_Mystery_First_Edition_Cover_1929.jpg", 99.999m, 100.000m, 1, false, true, "Misteri Tujuh Lonceng" },
                    { 2, new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1416), "The Witcher adalah rangkaian enam novel fantasi dan 15 cerita pendek  yang ditulis oleh penulis Polandia Andrzej SapkowskiSerial ini berputar di sekitar \"penyihir\" eponymous, Geralt of Rivia ", "https://upload.wikimedia.org/wikipedia/en/8/84/Season_of_Storms_Orion.jpg", 70.000m, 12.0000m, 2, false, true, "Season of Storms" },
                    { 3, new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1418), "The Lord of the Rings adalah sebuah novel epik   fantasi tinggi [a] oleh penulis dan sarjana Inggris J. R. R. Tolkien. Bertempat di Middle-earth, ceritanya dimulai sebagai sekuel dari buku anak-anak Tolkien tahun 1937 The Hobbit, tetapi akhirnya berkembang menjadi karya yang jauh lebih besar. ", "https://upload.wikimedia.org/wikipedia/en/thumb/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif/220px-First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif", 70.000m, 120.000m, 2, false, true, "Lord of the rings" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produk_IdKategori",
                table: "Produk",
                column: "IdKategori");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "Varian");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
