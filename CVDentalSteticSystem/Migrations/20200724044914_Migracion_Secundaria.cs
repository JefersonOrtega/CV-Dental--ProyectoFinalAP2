using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVDentalSteticSystem.Migrations
{
    public partial class Migracion_Secundaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "Procedimientos",
                columns: table => new
                {
                    ProcedimientoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacienteId = table.Column<int>(nullable: false),
                    TipoProcedimientoId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    EsCobrado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimientos", x => x.ProcedimientoId);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimientosDetalles",
                columns: table => new
                {
                    ProcedimientosDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProcedimientoId = table.Column<int>(nullable: false),
                    CitaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    ProcedimeintoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimientosDetalles", x => x.ProcedimientosDetalleId);
                    table.ForeignKey(
                        name: "FK_ProcedimientosDetalles_Procedimientos_ProcedimeintoId",
                        column: x => x.ProcedimeintoId,
                        principalTable: "Procedimientos",
                        principalColumn: "ProcedimientoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Contrasena", "Fecha", "NivelAcceso", "Nombres", "Usuario" },
                values: new object[] { 1, "YQBkAG0AaQBuAA==", new DateTime(2020, 7, 24, 0, 49, 13, 949, DateTimeKind.Local).AddTicks(4051), "Administrador", "admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimientosDetalles_ProcedimeintoId",
                table: "ProcedimientosDetalles",
                column: "ProcedimeintoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimientosDetalles");

            migrationBuilder.DropTable(
                name: "Procedimientos");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Contrasena", "Fecha", "NivelAcceso", "Nombres", "Usuario" },
                values: new object[] { 2, "YQBkAG0AaQBuAA==", new DateTime(2020, 7, 19, 2, 33, 18, 413, DateTimeKind.Local).AddTicks(1117), "Administrador", "admin", "admin" });
        }
    }
}
