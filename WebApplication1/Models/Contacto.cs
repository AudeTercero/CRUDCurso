using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contacto
    {
        [Key] //No es necesario si el nombre de la variable lleva la palabra Id
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El movil es obligatorio")]
        public string Movil { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
