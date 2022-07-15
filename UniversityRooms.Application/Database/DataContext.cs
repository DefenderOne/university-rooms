using Microsoft.EntityFrameworkCore;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Database;

public class DataContext : DbContext
{
    public DbSet<Building> Buildings { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<Faculty> Faculties { get; set; } = null!;
    public DbSet<Cathedra> Cathedras { get; set; } = null!;
    public DbSet<RoomType> RoomTypes { get; set; } = null!;

    public DataContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "User ID=postgres;Password=chrome989090;Host=localhost;Database=university_rooms_db;";
        optionsBuilder
            .UseNpgsql(connectionString)
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
