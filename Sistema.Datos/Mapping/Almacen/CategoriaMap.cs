using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;

namespace Sistema.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(c => c.idcategoria);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.descrpcion)
                .HasMaxLength(256);
        }
    }
}
