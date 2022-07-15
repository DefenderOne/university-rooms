using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database.Configurations;

public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
{
    public void Configure(EntityTypeBuilder<RoomType> builder)
    {
        builder.HasKey(rt => rt.Id);
        builder.HasMany(rt => rt.Rooms).WithOne(r => r.Type);
    }
}
