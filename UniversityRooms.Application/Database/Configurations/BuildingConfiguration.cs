using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database.Configurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired();
        builder.Property(b => b.LevelsCount).IsRequired();
        builder.Property(b => b.Address).IsRequired();
        builder.HasMany(b => b.Faculties).WithOne(f => f.Building);
        builder.HasMany(b => b.Rooms).WithOne(r => r.Building);
    }
}
