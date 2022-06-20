using BandEquipmentOCP.Models;


var bandMembers = new List<Musician>
{
    new Guitarist("Jerry", "Garia"),
    new Guitarist("Bob", "Weir"),
    new Bassist("Phil", "Lesh"),
    new Organist("Pigpen","McKernan"),
    new Drummer("Bill","Kreutzman"),
    new Percussionist("Mickey","Hart")
};

foreach (var bandMember in bandMembers)
{
    Console.WriteLine(bandMember);
}