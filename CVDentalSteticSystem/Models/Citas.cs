using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int PacienteId { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
    }
}
