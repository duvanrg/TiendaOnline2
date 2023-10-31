using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class RolPersonaConfiguration : IEntityTypeConfiguration<RolPersona>
    {
        public void Configure(EntityTypeBuilder<RolPersona> builder)
        {
            builder.ToTable("RolPersona");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.Property (p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}