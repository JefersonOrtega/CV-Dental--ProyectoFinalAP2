using CVDentalSteticSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<TiposProcedimientos> TiposProcedimientos { get; set; }
        public DbSet<Procedimientos> Procedimientos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cobros> Cobros { get; set; }
        public DbSet<TipoCitas> TipoCitas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\CVDentalSteticSystem.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .HasData(new Models.Usuarios
                {
                    UsuarioId = 1,
                    Nombres = "admin",
                    Usuario = "admin",
                    Contrasena = Models.Usuarios.Encriptar("admin"),
                    NivelAcceso = "Administrador",
                    Fecha = DateTime.Now
                });


            modelBuilder.Entity<Procedimientos>()
                .HasMany(p => p.ProcedimientoDetalle)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
