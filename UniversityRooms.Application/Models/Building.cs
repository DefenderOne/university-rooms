namespace UniversityRooms.UI.Models;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int LevelsCount { get; set; }
    public string Address { get; set; } = null!;
    public List<Room> Rooms { get; set; } = null!;
    public List<Faculty> Faculties { get; set; } = null!;
    public List<Cathedra> Cathedras { get; set; } = null!;
}
