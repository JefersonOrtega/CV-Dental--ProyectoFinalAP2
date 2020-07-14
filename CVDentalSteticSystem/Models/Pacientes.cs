using CVDentalSteticSystem.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Pacientes
    {
        [Key]
        public int PacienteId { get; set; }
        [Required(ErrorMessage ="Es Necesario introducir el Nombre")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="Es necesario introducir los apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Es Necesario introducir la dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es Necesario introducir un teléfono de contacto")]
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "Introduzca una direccion de correo electrónico valida")]
        public string Email { get; set; }
        [Required(ErrorMessage="Es necesario seleccionar el genero")]
        public string Genero { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string SeguroMedico { get; set; }
        public string Alergias { get; set; }
        public decimal Balance { get; set; }

    }
}
