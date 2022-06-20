namespace BandEquipmentOCP.Models;

record Drummer : Musician
{
    public Drummer(string firstName, string lastName)
    {
        id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        instrument = "Drum Kit";
        equipment = GetDrumEquipment();
    }

    private string GetDrumEquipment()
    {
        string drumEquipment =
            "Drum Sticks, Drum Covers, Cymbals";
        return drumEquipment;
    }
}
