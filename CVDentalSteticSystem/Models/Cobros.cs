using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public int PacienteId { get; set; }
        public int ProcedimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        [ForeignKey("CobroDetallesId")]
        public virtual List<CobroDetalles> CobroDetalles { get; set; } = new List<CobroDetalles>();
    }
}
