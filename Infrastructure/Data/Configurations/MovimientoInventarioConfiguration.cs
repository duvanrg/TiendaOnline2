using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MovimientoInventarioConfiguration : IEntityTypeConfiguration<MovimientoInventario>
    {
        public void Configure(EntityTypeBuilder<MovimientoInventario> builder)
        {
            builder.ToTable("MovimientoInventario");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder. Property (p => p.FechaMovimiento)
            .HasColumnType("datetime");

            builder. Property (p => p.FechaVencimiento)
            .HasColumnType("datetime");

            builder.HasOne (p => p.personaResponsable)
            .WithMany (p => p.movimientoInventariosResponsable)
            .HasForeignKey(p => p.IdResponsable);

            builder.HasOne (p => p.personaReceptor)
            .WithMany (p => p.movimientoInventariosReceptor)
            .HasForeignKey(p => p.personaReceptor);

            builder.HasOne (p => p.tipoMovimientoInventario)
            .WithMany (p => p.movimientosInventarios)
            .HasForeignKey(p => p.IdTipoMovimientoInventario);

            builder.HasOne (p => p.formaPago)
            .WithMany (p => p.movimientosInventarios)
            .HasForeignKey(p => p.IdFormaPago);
        }
    }
}