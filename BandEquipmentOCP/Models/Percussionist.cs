namespace BandEquipmentOCP.Models;

record Percussionist : Musician
{
    public Percussionist(string firstName, string lastName)
    {
        id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        instrument = "Percussion Kit";
        equipment = GetPercussionEquipment();
    }

    private string GetPercussionEquipment()
    {
        string percussionEquipment =
            "Drum Sticks, Drum Mallots, Drum Covers";
        return percussionEquipment;
    }
}
