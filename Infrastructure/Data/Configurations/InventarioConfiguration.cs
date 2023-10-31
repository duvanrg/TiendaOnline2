using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.Property (p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);
            
            builder. Property (p => p.Stock)
            .HasColumnType("smallint");
            
            builder. Property (p => p.StockMin)
            .HasColumnType("smallint");
            
            builder. Property (p => p.StockMax)
            .HasColumnType("smallint");

            builder.HasOne (p => p.producto)
            .WithMany (p => p.inventarios)
            .HasForeignKey(p => p.CodProducto);
        }
    }
}