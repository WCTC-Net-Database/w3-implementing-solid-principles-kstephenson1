namespace w3_assignment_ksteph.Character;

using CsvHelper.Configuration.Attributes;
using Spectre.Console;
using w3_assignment_ksteph.Csv;
using w3_assignment_ksteph.Inventory;
public class Character
{
    [Name("Name")]
    public required string Name { get; set; }

    [Name("Class")]
    public required string Class { get; set; }

    [Name("Level")]
    public required int Level { get; set; }

    [Name("HP")]
    public required int HitPoints { get; set; }

    [Name("Equipment")]
    [TypeConverter(typeof(InventoryConverter))]
    public required Inventory Inventory { get; set; }

    public Character()
    {

    }

    public Character(string name, string characterclass, int level, int hitPoints, Inventory inventory)
    {
        Name = name;
        Class = characterclass;
        Level = level;
        HitPoints = hitPoints;
        Inventory = inventory;
    }

    public void LevelUp()
    {
        Level++;
    }

    public void DisplayCharacterInfo()
    {
        Console.WriteLine($"{Name}  |  Level {Level} {Class}  |  HP: {HitPoints}");
        InventoryManager.ListInventory(Inventory);
    }

    public void DisplayCharacterInfo(String color)
    {
        AnsiConsole.MarkupLine($"{Name}  |  Level [{color}]{Level}[/] {Class}  |  HP: {HitPoints}");
        InventoryManager.ListInventory(Inventory);
    }

    public override string ToString()
    {
        return $"{Name},{Class},{Level},{HitPoints},{Inventory}";
    }
}
