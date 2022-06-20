namespace BandEquipmentOCP.Models;

record Organist : Musician
{
    public Organist(string firstName, string lastName)
    {
        id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        instrument = "Electric Organ";
        equipment = GetOrganEquipment();
    }

    private string GetOrganEquipment()
    {
        string organEquipment =
            "Amplifier Cords, Amplifier";
        return organEquipment;
    }
}
