using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.Property (p => p.NombreProd)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne (p => p.marca)
            .WithMany (p => p.productos)
            .HasForeignKey(p => p.IdMarca);
        }
    }
}