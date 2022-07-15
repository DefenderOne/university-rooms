using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database.Configurations
{
    internal class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasKey(f => f.Id);
            builder.HasMany(f => f.Cathedras).WithOne(c => c.Faculty);
            builder.Property(f => f.Name).IsRequired();
        }
    }
}
