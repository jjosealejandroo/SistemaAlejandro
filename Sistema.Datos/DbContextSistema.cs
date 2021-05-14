using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Mapping.Almacen;

namespace Sistema.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbContextSistema(DbContextOptions<DbContextSistema> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
