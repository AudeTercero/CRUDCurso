using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AplicationDBContext : DbContext    {
        public AplicationDBContext (DbContextOptions<AplicationDBContext>options) : base(options)
        { 

        }

        //Agregar los modelos aqui (Cada modelo corresponde a una tabla en la DB)
        public DbSet<Contacto> Contacto { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
