using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class TiposProcedimientos
    {
        [Key]
        public int TipoProcedimientoId { get; set; }
        [Required(ErrorMessage ="Es necesario digitar el nombre del procedimiento")]
        public string NombreProcedimiento { get; set; }
        [Required(ErrorMessage ="Es necesario digitar una breve descripcion del procedimiento")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Es necesario digitar el precio ")]
        public decimal Precio { get; set; }
    }
}
