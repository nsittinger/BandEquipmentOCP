namespace BandEquipmentOCP.Models;

record Bassist : Musician
{
    public Bassist(string firstName, string lastName)
    {
        id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        instrument = "Bass Guitar";
        equipment = GetBassEquipment();
    }

    private string GetBassEquipment()
    {
        string bassEquipment =
            "Bass Strings, Amplifier Cords, Amplifier";
        return bassEquipment;
    }
}
