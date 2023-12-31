using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TipoMovimientoInventarioConfiguration : IEntityTypeConfiguration<TipoMovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<TipoMovimientoInventario> builder)
        {
            builder.ToTable("TipoMovimientoInventario");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.Property (p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}