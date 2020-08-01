﻿using System;
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
                    Estado = table.Column<bool>(nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    PacienteId = table.Column<int>(nullable: false),
                    TipoCitaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                });

            migrationBuilder.CreateTable(
                name: "Cobros",
                columns: table => new
                {
                    CobroId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacienteId = table.Column<int>(nullable: false),
                    ProcedimientoId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobros", x => x.CobroId);
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
                    SeguroId = table.Column<int>(nullable: false),
                    Alergias = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

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
                name: "Seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.SeguroId);
                });

            migrationBuilder.CreateTable(
                name: "TipoCitas",
                columns: table => new
                {
                    TipoCitaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 256, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCitas", x => x.TipoCitaId);
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

            migrationBuilder.CreateTable(
                name: "CobroDetalles",
                columns: table => new
                {
                    CobroDetallesId = table.Column<int>(nullable: false),
                    CobroId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CobroDetalles", x => x.CobroDetallesId);
                    table.ForeignKey(
                        name: "FK_CobroDetalles_Cobros_CobroDetallesId",
                        column: x => x.CobroDetallesId,
                        principalTable: "Cobros",
                        principalColumn: "CobroId",
                        onDelete: ReferentialAction.Cascade);
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
                    ProcedimeintoDetalleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimientosDetalles", x => x.ProcedimientosDetalleId);
                    table.ForeignKey(
                        name: "FK_ProcedimientosDetalles_Procedimientos_ProcedimeintoDetalleId",
                        column: x => x.ProcedimeintoDetalleId,
                        principalTable: "Procedimientos",
                        principalColumn: "ProcedimientoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Contrasena", "Fecha", "NivelAcceso", "Nombres", "Usuario" },
                values: new object[] { 1, "YQBkAG0AaQBuAA==", new DateTime(2020, 7, 31, 11, 56, 53, 683, DateTimeKind.Local).AddTicks(5914), "Administrador", "admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimientosDetalles_ProcedimeintoDetalleId",
                table: "ProcedimientosDetalles",
                column: "ProcedimeintoDetalleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "CobroDetalles");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "ProcedimientosDetalles");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "TipoCitas");

            migrationBuilder.DropTable(
                name: "TiposProcedimientos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cobros");

            migrationBuilder.DropTable(
                name: "Procedimientos");
        }
    }
}