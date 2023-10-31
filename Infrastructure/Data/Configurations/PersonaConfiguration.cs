using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.Property (p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder. Property (p => p.FechaRegistro)
            .HasColumnType("datetime");
            
            builder.HasOne (p => p.tipoDocumento)
            .WithMany (p => p.personas)
            .HasForeignKey(p => p.IdDocumento);

            builder.HasOne (p => p.tipoPersona)
            .WithMany (p => p.personas)
            .HasForeignKey(p => p.IdTipoPersona);

            builder.HasOne (p => p.rolPersona)
            .WithMany (p => p.personas)
            .HasForeignKey(p => p.IdRolPersona);
        }
    }
}