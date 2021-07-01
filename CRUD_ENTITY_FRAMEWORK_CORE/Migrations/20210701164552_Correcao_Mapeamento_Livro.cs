using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    public partial class Correcao_Mapeamento_Livro : Migration
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
                value: new DateTime(2021, 7, 1, 13, 45, 51, 762, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 45, 51, 764, DateTimeKind.Local).AddTicks(5996));

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
                value: new DateTime(2021, 7, 1, 13, 18, 48, 175, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 1, 13, 18, 48, 177, DateTimeKind.Local).AddTicks(537));

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
