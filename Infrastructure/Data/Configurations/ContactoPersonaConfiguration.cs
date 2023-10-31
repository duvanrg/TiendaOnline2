using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
    {
        public void Configure(EntityTypeBuilder<ContactoPersona> builder)
        {
            builder.ToTable("ContactoPersona");
            builder.HasKey(e => e.Id);
            builder.Property (e => e.Id);

            builder.HasOne (p => p.persona)
            .WithMany (p => p.contactosPersonas)
            .HasForeignKey(p => p.IdPersona);

            builder.HasOne (p => p.tipoContacto)
            .WithMany (p => p.contactosPersonas)
            .HasForeignKey(p => p.IdTipoContacto);
        }
    }
}