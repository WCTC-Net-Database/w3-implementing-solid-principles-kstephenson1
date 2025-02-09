namespace w3_assignment_ksteph.Character;

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

    public void DisplayCharacterInfo()
    {
        Console.WriteLine($"{Name}  |  Level {Level} {Class}  |  HP: {HitPoints}");
        InventoryManager.ListInventory(Inventory);
    }
}
