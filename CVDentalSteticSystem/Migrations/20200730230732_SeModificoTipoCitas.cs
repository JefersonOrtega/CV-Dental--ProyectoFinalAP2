using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVDentalSteticSystem.Migrations
{
    public partial class SeModificoTipoCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "TipoCitas",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 30, 19, 7, 31, 611, DateTimeKind.Local).AddTicks(5663));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "TipoCitas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 30, 18, 17, 48, 922, DateTimeKind.Local).AddTicks(5185));
        }
    }
}
