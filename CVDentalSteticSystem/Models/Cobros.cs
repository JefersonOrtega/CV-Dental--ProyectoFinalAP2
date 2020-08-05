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
        [Required(ErrorMessage = "Debe seleccionar un paciente!")]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un procedimiento!")]
        public int ProcedimientoId { get; set; }
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "0:dd/MM/yyyy hh:mm tt")]
        [Required(ErrorMessage = "Debe seleccionar una fecha para la cita")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Debe colocar un monto!")]
        public decimal Monto { get; set; }
        [ForeignKey("CobroDetallesId")]
        public virtual List<CobroDetalles> CobroDetalles { get; set; } = new List<CobroDetalles>();
    }
}
