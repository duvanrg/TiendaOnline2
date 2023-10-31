using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UbicacionPersonaConfiguration : IEntityTypeConfiguration<UbicacionPersona>
    {
        public void Configure(EntityTypeBuilder<UbicacionPersona> builder)
        {
            builder.ToTable("UbicacionPersona");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder. Property (p => p.TipoDeVia)
            .HasMaxLength(50);

            builder. Property (p => p.NumeroPri)
            .HasColumnType("smallint");

            builder. Property (p => p.Letra)
            .HasMaxLength(2);

            builder.Property (p => p.Bis)
            .HasMaxLength(10);

            builder.Property (p => p.LetraSec)
            .HasMaxLength(2);

            builder.Property (p => p.Cardinal)
            .HasMaxLength(10);

            builder. Property (p => p.NumeroSec)
            .HasColumnType("smallint");

            builder.Property (p => p.LetraTer)
            .HasMaxLength(2);

            builder. Property (p => p.NumeroTer)
            .HasColumnType("smallint");

            builder.Property (p => p.CardinalSec)
            .HasMaxLength(10);    

            builder.Property (p => p.Complemento)
            .HasMaxLength(50);

            builder.HasOne (p => p.persona)
            .WithMany (p => p.ubicacionesPersonas)
            .HasForeignKey(p => p.IdPersona);

            builder.HasOne (p => p.ciudad)
            .WithMany (p => p.ubicacionesPersonas)
            .HasForeignKey(p => p.IdCiudad);
        }
    }
}