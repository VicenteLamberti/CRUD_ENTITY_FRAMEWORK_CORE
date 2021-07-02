using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Migrations
{
    public partial class Criacao_tabela_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Password = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Permissao = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 90, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 92, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 92, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 92, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 92, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 7, 2, 8, 35, 59, 92, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Password", "Permissao", "UserName" },
                values: new object[] { 1, "vicente@", "123", "admin", "vicente" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

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
        }
    }
}
