using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EspaçoVerdeLogin.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoResiduos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Localizacoes",
                columns: new[] { "ID_Localizacao", "Cidade", "Estado" },
                values: new object[,]
                {
                    { 1, "Araraquara", "SP" },
                    { 2, "Matão", "SP" },
                    { 3, "São Carlos", "SP" },
                    { 4, "Ribeirão Preto", "SP" }
                });

            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "ID_Residuo", "ID_Localizacao", "ID_Usuario", "ImgUrl", "Nome", "PrecoKg", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "452ef72f-2445-4c17-b890-aa127b7275ca", "aco_inox.webp", "Aço Inox", 5.50m, 100m },
                    { 2, 2, "452ef72f-2445-4c17-b890-aa127b7275ca", "ferro_fundido.webp", "Ferro Fundido", 1.20m, 50m },
                    { 3, 3, "452ef72f-2445-4c17-b890-aa127b7275ca", "aluminio.webp", "Alumínio", 3.80m, 75m },
                    { 4, 4, "452ef72f-2445-4c17-b890-aa127b7275ca", "cobre.webp", "Cobre", 8.20m, 30m },
                    { 5, 1, "452ef72f-2445-4c17-b890-aa127b7275ca", "latao.webp", "Latão", 4.50m, 60m },
                    { 6, 2, "452ef72f-2445-4c17-b890-aa127b7275ca", "zinco.webp", "Zinco", 2.10m, 40m },
                    { 7, 3, "452ef72f-2445-4c17-b890-aa127b7275ca", "chumbo.webp", "Chumbo", 1.80m, 25m },
                    { 9, 1, "452ef72f-2445-4c17-b890-aa127b7275ca", "niquel.webp", "Níquel", 12.00m, 10m },
                    { 10, 2, "452ef72f-2445-4c17-b890-aa127b7275ca", "titanio.webp", "Titânio", 25.00m, 5m },
                    { 11, 3, "452ef72f-2445-4c17-b890-aa127b7275ca", "bronze.webp", "Bronze", 6.80m, 12m },
                    { 12, 4, "452ef72f-2445-4c17-b890-aa127b7275ca", "aco_carbono.webp", "Aço Carbono", 0.90m, 22m },
                    { 13, 1, "452ef72f-2445-4c17-b890-aa127b7275ca", "magnesio.webp", "Magnésio", 4.20m, 18m },
                    { 14, 2, "452ef72f-2445-4c17-b890-aa127b7275ca", "cromo.webp", "Cromo", 7.10m, 16m },
                    { 15, 3, "452ef72f-2445-4c17-b890-aa127b7275ca", "manganes.webp", "Manganês", 1.50m, 20m },
                    { 17, 1, "452ef72f-2445-4c17-b890-aa127b7275ca", "molibdenio.webp", "Molibdênio", 28.00m, 2m },
                    { 18, 2, "452ef72f-2445-4c17-b890-aa127b7275ca", "vanadio.webp", "Vanádio", 15.50m, 7m },
                    { 19, 3, "452ef72f-2445-4c17-b890-aa127b7275ca", "aco_inox.webp", "Aço Inox", 5.70m, 15m },
                    { 20, 4, "452ef72f-2445-4c17-b890-aa127b7275ca", "aluminio.webp", "Alumínio", 4.00m, 50m }
                });

            migrationBuilder.InsertData(
                table: "Transacoes",
                columns: new[] { "ID_Transacao", "Data_Transacao", "ID_Comprador", "ID_Residuo", "Preco_Final" },
                values: new object[] { 1, new DateTime(2025, 6, 8, 14, 8, 47, 132, DateTimeKind.Local).AddTicks(5730), "452ef72f-2445-4c17-b890-aa127b7275ca", 1, 550m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transacoes",
                keyColumn: "ID_Transacao",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Localizacoes",
                keyColumn: "ID_Localizacao",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Localizacoes",
                keyColumn: "ID_Localizacao",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Localizacoes",
                keyColumn: "ID_Localizacao",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Localizacoes",
                keyColumn: "ID_Localizacao",
                keyValue: 1);
        }
    }
}
