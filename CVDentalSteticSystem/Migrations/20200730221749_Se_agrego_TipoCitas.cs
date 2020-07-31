using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVDentalSteticSystem.Migrations
{
    public partial class Se_agrego_TipoCitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoCitas",
                columns: table => new
                {
                    TipoCitaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCitas", x => x.TipoCitaId);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 30, 18, 17, 48, 922, DateTimeKind.Local).AddTicks(5185));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoCitas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 7, 29, 23, 50, 48, 566, DateTimeKind.Local).AddTicks(9966));
        }
    }
}
