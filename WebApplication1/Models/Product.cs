using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } 

        [Required(ErrorMessage = "Debe introducir el nombre del producto.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Debe introducir el precio del producto.")]
        public float Price { get; set; }
    }
}
