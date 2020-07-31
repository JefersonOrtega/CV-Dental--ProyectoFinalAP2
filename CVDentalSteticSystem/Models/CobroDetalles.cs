using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class CobroDetalles
    {
        [Key]
        public int CobroDetallesId { get; set; }
        public int CobroId { get; set; }
        public string Descripcion { get; set; }
    }
}
