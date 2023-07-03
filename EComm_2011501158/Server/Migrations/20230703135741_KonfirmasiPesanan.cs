using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class KonfirmasiPesanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "KonfirmasiPesanan",
                columns: new[] { "IdKonfirmasi", "IdPesanan", "BankTransfer", "JumlahTransfer", "TglKonfirmasi", "TglTransfer" },
                values: new object[,]
                {
                    { 1, 1, "BCA", 0m, new DateTime(2023, 7, 3, 20, 57, 41, 165, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 7, 3, 20, 57, 41, 165, DateTimeKind.Local).AddTicks(6585) },
                    { 2, 1, "BCA", 10000.00m, new DateTime(2023, 7, 3, 20, 57, 41, 165, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 7, 3, 20, 57, 41, 165, DateTimeKind.Local).AddTicks(6589) }
                });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 7, 3, 20, 57, 41, 164, DateTimeKind.Local).AddTicks(7953) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KonfirmasiPesanan");

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
        }
    }
}
