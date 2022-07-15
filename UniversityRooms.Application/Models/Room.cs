namespace UniversityRooms.UI.Models;

public class Room
{
    public int Id { get; set; }
    
    public int BuildingId { get; set; }
    public Building Building { get; set; } = null!;
    public string Number { get; set; } = null!;
    public int Level { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }
    public int RoomTypeId { get; set; }
    public RoomType Type { get; set; } = null!;
}
