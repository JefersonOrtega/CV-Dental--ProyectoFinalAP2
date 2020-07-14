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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= C:\BasesDeDatosAp2\DVDentalSteticSystem.db");
        }

    }
}
