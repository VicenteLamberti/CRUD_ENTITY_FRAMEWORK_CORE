using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Autor = table.Column<string>(type: "VARCHAR(151)", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Preco = table.Column<decimal>(type: "NUMERIC(38,2)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Software" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 1, "Autor 1", 1, new DateTime(2021, 7, 1, 13, 18, 48, 175, DateTimeKind.Local).AddTicks(7863), 50m, 10, "Titulo 1" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 2, "Autor 2", 1, new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(514), 770m, 10, "Titulo 2" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 3, "Autor 3", 1, new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(532), 580m, 10, "Titulo 3" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 4, "Autor 4", 1, new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(534), 30m, 10, "Titulo 4" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 5, "Autor 5", 1, new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(535), 250m, 10, "Titulo 5" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 6, "Autor 6", 1, new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(537), 505m, 10, "Titulo 6" });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaId",
                table: "Livro",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Titulo",
                table: "Livro",
                column: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
