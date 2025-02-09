namespace w3_assignment_ksteph.Character;

using System.Reflection.Emit;
using System.Xml.Linq;
using w3_assignment_ksteph.Csv;
using w3_assignment_ksteph.Inventory;
public class Character
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
    public Inventory Inventory { get; set; }

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

    public CsvCharacterIO ToCsvCharacterIO()
    {
        return new() { Name = Name, Class = Class, Level = Level, HitPoints = HitPoints, Inventory = InventoryManager.ToString(Inventory) };
    }

    public void DisplayCharacterInfo()
    {
        Console.WriteLine($"{Name}  |  Level {Level} {Class}  |  HP: {HitPoints}");
        InventoryManager.ListInventory(Inventory);
    }
}
