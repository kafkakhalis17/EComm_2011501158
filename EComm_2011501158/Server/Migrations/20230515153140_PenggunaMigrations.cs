using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComm_2011501158.Server.Migrations
{
    /// <inheritdoc />
    public partial class PenggunaMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    TeleponPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoPengguna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglLahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengguna", x => x.IdPengguna);
                });

            migrationBuilder.InsertData(
                table: "Pengguna",
                columns: new[] { "IdPengguna", "Admin", "AlamatPengguna", "EmailPengguna", "FotoPengguna", "KonfirmPassword", "NamaPengguna", "Password", "TeleponPengguna", "TglLahir", "Username" },
                values: new object[] { 1, true, "Jl. Budiyanto No.2 Jakarta", "Khaliskafka@mail.com", "https://i.pinimg.com/564x/b6/24/7a/b6247a4b03bc5a296ac7f694b6b72863.jpg", "", "kafka khalis", "admin123", "08193818311", new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "kafka17" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pengguna");

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Produk",
                keyColumn: "IdProduk",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 5, 1, 4, 37, 2, 205, DateTimeKind.Local).AddTicks(1418) });
        }
    }
}
