using Declaraciones.Data.Models.Declaraciones;
using Microsoft.EntityFrameworkCore;

namespace API_Declaraciones.Data.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Declaracion> Declaraciones { get; set; }

        public DbSet<Articulo> Articulos { get; set; }

        public DbSet<Liquidacion> Liquidaciones { get; set; }

        public DbSet<LiquidacionArticulo> LiquidacionesArticulo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>()
                .HasKey(a => new { a.Iddt, a.Nart });

            modelBuilder.Entity<LiquidacionArticulo>()
                .HasKey(a => new
                {
                    a.Iliq,
                    a.Nart,
                    a.Clqatax,
                    a.Clqatyp,
                });


            base.OnModelCreating(modelBuilder);
        }
    }
}
