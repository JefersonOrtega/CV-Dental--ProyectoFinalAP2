using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class TipoCitas
    {
        [Key]
        public int TipoCitaId { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del tipo de cita"), MaxLength(256), MinLength(5)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe colocar una descripcion del tipo cita"), MaxLength(256), MinLength(5)]
        public string Descripcion { get; set; }
    }
}
