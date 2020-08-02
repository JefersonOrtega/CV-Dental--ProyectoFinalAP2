﻿// <auto-generated />
using System;
using CVDentalSteticSystem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CVDentalSteticSystem.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200801223743_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("CVDentalSteticSystem.Models.Citas", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoCitaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CitaId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.CobroDetalles", b =>
                {
                    b.Property<int>("CobroDetallesId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Abono")
                        .HasColumnType("TEXT");

                    b.Property<int>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("CobroDetallesId");

                    b.ToTable("CobroDetalles");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProcedimientoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.Pacientes", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alergias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeguroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.Procedimientos", b =>
                {
                    b.Property<int>("ProcedimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsCobrado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoProcedimientoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProcedimientoId");

                    b.ToTable("Procedimientos");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.ProcedimientosDetalles", b =>
                {
                    b.Property<int>("ProcedimientosDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CitaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProcedimeintoDetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProcedimientoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProcedimientosDetalleId");

                    b.HasIndex("ProcedimeintoDetalleId");

                    b.ToTable("ProcedimientosDetalles");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.Seguros", b =>
                {
                    b.Property<int>("SeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SeguroId");

                    b.ToTable("Seguros");

                    b.HasData(
                        new
                        {
                            SeguroId = 1,
                            Nombre = "No Posee"
                        });
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.TipoCitas", b =>
                {
                    b.Property<int>("TipoCitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("TipoCitaId");

                    b.ToTable("TipoCitas");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.TiposProcedimientos", b =>
                {
                    b.Property<int>("TipoProcedimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreProcedimiento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoProcedimientoId");

                    b.ToTable("TiposProcedimientos");
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelAcceso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Contrasena = "YQBkAG0AaQBuAA==",
                            Fecha = new DateTime(2020, 8, 1, 18, 37, 42, 711, DateTimeKind.Local).AddTicks(9954),
                            NivelAcceso = "Administrador",
                            Nombres = "admin",
                            Usuario = "admin"
                        });
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.CobroDetalles", b =>
                {
                    b.HasOne("CVDentalSteticSystem.Models.Cobros", null)
                        .WithMany("CobroDetalles")
                        .HasForeignKey("CobroDetallesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CVDentalSteticSystem.Models.ProcedimientosDetalles", b =>
                {
                    b.HasOne("CVDentalSteticSystem.Models.Procedimientos", null)
                        .WithMany("ProcedimientoDetalle")
                        .HasForeignKey("ProcedimeintoDetalleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}