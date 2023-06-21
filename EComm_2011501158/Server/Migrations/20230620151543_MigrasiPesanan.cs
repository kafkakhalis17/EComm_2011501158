using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class MigrasiPesanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 6, 20, 22, 15, 43, 439, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.CreateIndex(
                name: "IX_PesananProduk_IdProduk",
                table: "PesananProduk",
                column: "IdProduk");

            migrationBuilder.CreateIndex(
                name: "IX_PesananProduk_IdVarian",
                table: "PesananProduk",
                column: "IdVarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PesananProduk");

            migrationBuilder.DropTable(
                name: "Pesanan");

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 6, 18, 23, 33, 46, 313, DateTimeKind.Local).AddTicks(2609) });
        }
    }
}
