namespace BandEquipmentOCP.Models;

public record Musician
{
    public Guid id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string instrument { get; set; }
    public string equipment { get; set; }
}
