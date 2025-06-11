using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspaçoVerdeLogin.Migrations
{
    /// <inheritdoc />
    public partial class UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 6, 11, 9, 25, 2, 100, DateTimeKind.Local).AddTicks(8387));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 6, 10, 20, 58, 34, 55, DateTimeKind.Local).AddTicks(7697));
        }
    }
}
