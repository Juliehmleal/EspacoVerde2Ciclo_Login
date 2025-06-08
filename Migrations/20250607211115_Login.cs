using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspaçoVerdeLogin.Migrations
{
    /// <inheritdoc />
    public partial class Login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Localizacoes",
                columns: table => new
                {
                    ID_Localizacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacoes", x => x.ID_Localizacao);
                });

            migrationBuilder.CreateTable(
                name: "Residuos",
                columns: table => new
                {
                    ID_Residuo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_Localizacao = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residuos", x => x.ID_Residuo);
                    table.ForeignKey(
                        name: "FK_Residuos_AspNetUsers_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residuos_Localizacoes_ID_Localizacao",
                        column: x => x.ID_Localizacao,
                        principalTable: "Localizacoes",
                        principalColumn: "ID_Localizacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    ID_Transacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Residuo = table.Column<int>(type: "int", nullable: false),
                    ID_Comprador = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data_Transacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco_Final = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.ID_Transacao);
                    table.ForeignKey(
                        name: "FK_Transacoes_AspNetUsers_ID_Comprador",
                        column: x => x.ID_Comprador,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transacoes_Residuos_ID_Residuo",
                        column: x => x.ID_Residuo,
                        principalTable: "Residuos",
                        principalColumn: "ID_Residuo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_ID_Localizacao",
                table: "Residuos",
                column: "ID_Localizacao");

            migrationBuilder.CreateIndex(
                name: "IX_Residuos_ID_Usuario",
                table: "Residuos",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ID_Comprador",
                table: "Transacoes",
                column: "ID_Comprador");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ID_Residuo",
                table: "Transacoes",
                column: "ID_Residuo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Residuos");

            migrationBuilder.DropTable(
                name: "Localizacoes");
        }
    }
}
