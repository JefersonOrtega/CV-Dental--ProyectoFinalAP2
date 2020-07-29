using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Procedimientos
    {
        [Key]
        public int ProcedimientoId { get; set; }
        [Required(ErrorMessage = "Es necesario seleccionar un Paciente")]
        [Range(1, 1000000,ErrorMessage = "Seleccione un paciente")]
        public int PacienteId { get; set; }
        [Required(ErrorMessage = "Es necesario seleccionar un Tipo de Procedimiento")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione un Tipo de Procedimiento")]
        public int TipoProcedimientoId { get; set; }
        [Required(ErrorMessage ="Es necesario seleccionar un estado")]
        public string Estado { get; set; }  
        public decimal Monto { get; set; }
        public bool EsCobrado { get; set; } //Si esta cobrado o no
        //public int UsuarioId { get; set; }

        [ForeignKey("ProcedimeintoDetalleId")]
        public virtual List<ProcedimientosDetalles> ProcedimientoDetalle { get; set; } = new List<ProcedimientosDetalles>();

    }
}
