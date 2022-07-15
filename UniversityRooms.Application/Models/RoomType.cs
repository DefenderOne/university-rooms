namespace UniversityRooms.UI.Models;

public class RoomType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Room> Rooms { get; set; } = null!;
}
