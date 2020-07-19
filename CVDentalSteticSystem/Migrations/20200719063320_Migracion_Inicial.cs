using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVDentalSteticSystem.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<string>(nullable: true),
                    PacienteId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    Observacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    SeguroMedico = table.Column<string>(nullable: true),
                    Alergias = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "TiposProcedimientos",
                columns: table => new
                {
                    TipoProcedimientoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreProcedimiento = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposProcedimientos", x => x.TipoProcedimientoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(maxLength: 30, nullable: false),
                    Contrasena = table.Column<string>(nullable: false),
                    NivelAcceso = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Contrasena", "Fecha", "NivelAcceso", "Nombres", "Usuario" },
                values: new object[] { 2, "YQBkAG0AaQBuAA==", new DateTime(2020, 7, 19, 2, 33, 18, 413, DateTimeKind.Local).AddTicks(1117), "Administrador", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "TiposProcedimientos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
