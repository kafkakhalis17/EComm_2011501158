using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class MigrasiProdukVarian : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_ProdukVarian_IdVarian",
                table: "ProdukVarian",
                column: "IdVarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdukVarian");

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
