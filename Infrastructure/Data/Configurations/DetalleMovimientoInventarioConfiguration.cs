using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleMovimientoInventarioConfiguration : IEntityTypeConfiguration<DetalleMovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<DetalleMovimientoInventario> builder)
        {
            builder.ToTable("DetalleMovimientoInventario");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder. Property (p => p.Cantidad)
            .HasColumnType("smallint");

            builder. Property (p => p.Precio)
            .HasColumnType("decimal");

            builder.HasOne (p => p.inventario)
            .WithMany (p => p.detallesMovimientosInventarios)
            .HasForeignKey(p => p.IdInventario);

            builder.HasOne (p => p.movimientoInventario)
            .WithMany (p => p.movimientosInventarios)
            .HasForeignKey(p => p.IdMovInv);
        }
    }
}