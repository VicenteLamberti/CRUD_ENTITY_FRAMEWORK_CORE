using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    public partial class Correcao_3_Mapeamento_Livro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 147, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 148, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 148, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 148, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 148, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 54, 23, 148, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 357, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 358, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 358, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 358, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 358, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 53, 56, 358, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
