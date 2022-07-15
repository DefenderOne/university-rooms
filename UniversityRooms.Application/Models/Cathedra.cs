namespace UniversityRooms.UI.Models;

public class Cathedra
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; } = null!;
    public Building Building { get; set; } = null!;
}
