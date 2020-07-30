using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }
        public Procedimientos ProcedimientoId { get; set; }
        public Usuarios UsuarioId { get; set; }
    }
}
