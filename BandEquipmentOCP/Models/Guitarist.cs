namespace BandEquipmentOCP.Models;

record Guitarist : Musician
{
    public Guitarist(string firstName, string lastName)
    {
        id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        instrument = "Guitar";
        equipment = GetGuitarEquipment();
    }

    private string GetGuitarEquipment()
    {
        string guitarEquipment =
            "Guitar Strings, Amplifier Cords, Amplifier";
        return guitarEquipment;
    }
}
