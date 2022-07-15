using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Number).IsRequired();
        builder.Property(r => r.Level).IsRequired();
        builder.Property(r => r.Width).IsRequired();
        builder.Property(r => r.Height).IsRequired();
        builder.Property(r => r.Length).IsRequired();
    }
}
