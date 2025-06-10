using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspaçoVerdeLogin.Migrations
{
    /// <inheritdoc />
    public partial class VersaoPrevia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 3,
                column: "ID_Usuario",
                value: "1c446a24-6366-4295-a2a3-3ae57de78fb8");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 5,
                column: "ID_Usuario",
                value: "f745a310-7c58-4fb5-82f8-05db5a5de659");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 10,
                column: "ID_Usuario",
                value: "f745a310-7c58-4fb5-82f8-05db5a5de659");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 13,
                column: "ID_Usuario",
                value: "f745a310-7c58-4fb5-82f8-05db5a5de659");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 18,
                column: "ID_Usuario",
                value: "f745a310-7c58-4fb5-82f8-05db5a5de659");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 20,
                column: "ID_Usuario",
                value: "1c446a24-6366-4295-a2a3-3ae57de78fb8");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 6, 10, 20, 58, 34, 55, DateTimeKind.Local).AddTicks(7697));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 3,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 5,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 10,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 13,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 18,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 20,
                column: "ID_Usuario",
                value: "452ef72f-2445-4c17-b890-aa127b7275ca");

            migrationBuilder.UpdateData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1,
                column: "Data_Transacao",
                value: new DateTime(2025, 6, 8, 14, 8, 47, 132, DateTimeKind.Local).AddTicks(5730));
        }
    }
}
