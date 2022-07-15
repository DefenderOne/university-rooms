namespace UniversityRooms.UI.Models;

public class Faculty
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int BuildingId { get; set; }
    public Building Building { get; set; } = null!;
    public List<Cathedra> Cathedras { get; set; } = null!;
}
