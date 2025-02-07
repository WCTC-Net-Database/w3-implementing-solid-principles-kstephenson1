namespace w3_assignment_ksteph.Csv;

using CsvHelper.Configuration.Attributes;
using Character;
using w3_assignment_ksteph.Inventory;

// The Character class is used to store the character information while the csv is being read and written.
public class CsvCharacterIO
{
    // Properties with Attributes for use with CSVHelper Headers
    [Name("Name")]
    public required string Name { get; set; }

    [Name("Class")]
    public required string Class { get; set; }

    [Name("Level")]
    public required int Level { get; set; }

    [Name("HP")]
    public required int HitPoints { get; set; }

    [Name("Equipment")]
    public required string? Inventory { get; set; }

    public CsvCharacterIO() { }

    public override string ToString()
    {
        return $"{Name},{Class},{Level},{HitPoints},{Inventory}";
    }

    public Character ToCharacter()
    {
        return new(Name, Class, Level, HitPoints, InventoryManager.ToInventory(Inventory!));
    }

}
