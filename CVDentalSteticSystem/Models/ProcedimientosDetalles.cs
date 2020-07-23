using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class ProcedimientosDetalles
    {
        [Key]
        public int ProcedimientosDetalleId { get; set; }
        public int ProcedimientoId { get; set; }
        public int CitaId { get; set; }
        public string Descripcion { get; set; } //Lo que se ha hecho...

    }
}
