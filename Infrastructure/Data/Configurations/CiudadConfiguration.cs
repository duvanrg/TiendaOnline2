using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("Ciudad");
        builder.HasKey(e=> e.id);
        builder.Property(e=> e.id);

        builder.Property(p=>p.Nombre).IsRequired().HasMaxLength(50);

        builder.HasOne(p=> p.Departamentos).WithMany(p=> p.ciudades).HasForeignKey(p=> p.idDepartamentoFk);
    }
}
