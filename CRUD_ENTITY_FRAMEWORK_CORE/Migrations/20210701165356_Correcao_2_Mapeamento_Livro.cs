using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    public partial class Correcao_2_Mapeamento_Livro : Migration
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
    }
}
