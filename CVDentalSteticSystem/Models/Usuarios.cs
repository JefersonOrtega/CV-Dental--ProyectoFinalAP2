using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVDentalSteticSystem.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir una fecha")]
        [Range(typeof(DateTime), minimum: "1/7/2020", maximum: "1/1/2060", ErrorMessage = "La fecha esta fuera de rango")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un nombre")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre es muy largo")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Es necesario introducir el nombre de usuario")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre de usuario es muy largo")]
        public string Usuario { get; set; }        
        [Required(ErrorMessage = "Es necesario introducir una Contraseña")]
        public string Contrasena { get; set; }
        [Required(ErrorMessage = "Es necesario introducir un nivel de acceso")]
        public string NivelAcceso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Usuario = string.Empty;
            Contrasena = string.Empty;
            NivelAcceso = string.Empty;
            Fecha = DateTime.Now;
        }



        public static string Encriptar(string cadenaEncriptada)
        {
            if (!string.IsNullOrEmpty(cadenaEncriptada))
            {
                string resultado = string.Empty;
                byte[] encryted = Encoding.Unicode.GetBytes(cadenaEncriptada);
                resultado = Convert.ToBase64String(encryted);

                return resultado;
            }
            return string.Empty;
        }

        public static string DesEncriptar(string cadenaDesencriptada)
        {
            if (!string.IsNullOrEmpty(cadenaDesencriptada))
            {
                string resultado = string.Empty;
                byte[] decryted = Convert.FromBase64String(cadenaDesencriptada);
                resultado = System.Text.Encoding.Unicode.GetString(decryted);

                return resultado;
            }

            return string.Empty;
        }

    }
}
