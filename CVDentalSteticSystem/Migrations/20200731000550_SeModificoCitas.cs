using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVDentalSteticSystem.Migrations
{
    public partial class SeModificoCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoCitaId",
                table: "Citas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 30, 20, 5, 50, 91, DateTimeKind.Local).AddTicks(5163));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoCitaId",
                table: "Citas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 30, 19, 7, 31, 611, DateTimeKind.Local).AddTicks(5663));
        }
    }
}
