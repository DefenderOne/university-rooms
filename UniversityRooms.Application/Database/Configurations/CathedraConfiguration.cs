using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database.Configurations
{
    internal class CathedraConfiguration : IEntityTypeConfiguration<Cathedra>
    {
        public void Configure(EntityTypeBuilder<Cathedra> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();
        }
    }
}
