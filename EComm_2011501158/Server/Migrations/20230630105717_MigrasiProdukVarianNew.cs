using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class MigrasiProdukVarianNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeleponPengguna",
                table: "Pengguna",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1973), new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1977), new DateTime(2023, 6, 30, 17, 57, 17, 48, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.InsertData(
                table: "Varian",
                columns: new[] { "IdVarian", "Nama" },
                values: new object[,]
                {
                    { 1, "Fisik" },
                    { 2, "Digital" },
                    { 3, "Special Edition" },
                    { 4, "Special Edition + Author sign" }
                });

            migrationBuilder.InsertData(
                table: "ProdukVarian",
                columns: new[] { "IdProduk", "IdVarian", "HargaOriVarian", "HargaVarian" },
                values: new object[,]
                {
                    { 1, 1, 130.000m, 120.000m },
                    { 1, 2, 100.000m, 60.000m },
                    { 1, 3, 240.000m, 185.000m },
                    { 2, 1, 120.000m, 100.000m },
                    { 2, 2, 100.000m, 75.000m },
                    { 2, 4, 360.000m, 320.000m },
                    { 3, 1, 360.000m, 300.000m },
                    { 3, 3, 600.000m, 520.000m }
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
                name: "IX_ProdukVarian_IdVarian",
                table: "ProdukVarian",
                column: "IdVarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PesananProduk");

            migrationBuilder.DropTable(
                name: "ProdukVarian");

            migrationBuilder.DropTable(
                name: "Pesanan");

            migrationBuilder.DeleteData(
                table: "Varian",
                keyColumn: "IdVarian",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Varian",
                keyColumn: "IdVarian",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Varian",
                keyColumn: "IdVarian",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Varian",
                keyColumn: "IdVarian",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "TeleponPengguna",
                table: "Pengguna",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 5, 15, 22, 31, 39, 774, DateTimeKind.Local).AddTicks(4681) });
        }
    }
}
