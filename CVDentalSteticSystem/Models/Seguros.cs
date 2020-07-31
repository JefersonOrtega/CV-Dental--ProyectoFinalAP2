using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Seguros
    {
        [Key]
        public int SeguroId { get; set; }
        [Required(ErrorMessage = "Debe completar este campo")]
        public string Nombre { get; set; }
    }
}
