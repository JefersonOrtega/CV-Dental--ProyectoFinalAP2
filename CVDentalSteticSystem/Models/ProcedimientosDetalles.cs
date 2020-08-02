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
        [Required(ErrorMessage ="Debe seleccionar una cita correspondiente al paciente")]
        public int CitaId { get; set; }
        [Required(ErrorMessage ="Es necesario introducir una descripción")]
        public string Descripcion { get; set; } //Lo que se ha hecho...

        
    }
}
