using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class PaisConfiguration: IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais");
        builder.HasKey(e => e.id);
        builder.Property(e => e.id);

        builder.Property(p=>p.Nombre).IsRequired().HasMaxLength(50);
    }
}