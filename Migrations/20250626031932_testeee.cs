using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EspaçoVerdeLogin.Migrations
{
    /// <inheritdoc />
    public partial class testeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "ID_Residuo", "ID_Localizacao", "ID_Usuario", "ImgUrl", "Nome", "PrecoKg", "Quantidade" },
                values: new object[,]
                {
                    { -20, 4, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "aluminio.webp", "Alumínio", 4.00m, 50m },
                    { -19, 3, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "aco_inox.webp", "Aço Inox", 5.70m, 15m },
                    { -18, 2, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "vanadio.webp", "Vanádio", 15.50m, 7m },
                    { -17, 1, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "molibdenio.webp", "Molibdênio", 28.00m, 2m },
                    { -15, 3, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "manganes.webp", "Manganês", 1.50m, 20m },
                    { -14, 2, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "cromo.webp", "Cromo", 7.10m, 16m },
                    { -13, 1, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "magnesio.webp", "Magnésio", 4.20m, 18m },
                    { -12, 4, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "aco_carbono.webp", "Aço Carbono", 0.90m, 22m },
                    { -11, 3, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "bronze.webp", "Bronze", 6.80m, 12m },
                    { -10, 2, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "titanio.webp", "Titânio", 25.00m, 5m },
                    { -9, 1, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "niquel.webp", "Níquel", 12.00m, 10m },
                    { -7, 3, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "chumbo.webp", "Chumbo", 1.80m, 25m },
                    { -6, 2, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "zinco.webp", "Zinco", 2.10m, 40m },
                    { -5, 1, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "latao.webp", "Latão", 4.50m, 60m },
                    { -4, 4, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "cobre.webp", "Cobre", 8.20m, 30m },
                    { -3, 3, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "aluminio.webp", "Alumínio", 3.80m, 75m },
                    { -2, 2, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "ferro_fundido.webp", "Ferro Fundido", 1.20m, 50m },
                    { -1, 1, "9eada58b-13f5-45d3-be4b-c4d49fff8b2a", "aco_inox.webp", "Aço Inox", 5.50m, 100m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "ID_Residuo",
                keyValue: -1);
        }
    }
}
