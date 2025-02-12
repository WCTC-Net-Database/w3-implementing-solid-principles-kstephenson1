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

    public Character() { }

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

        Grid charTable = new Grid().Width(25).AddColumn().RightAligned();
        charTable
            .AddRow(new Text(Name).Centered())
            .AddRow(new Text($"Level {Level} {Class}").Centered());

        Grid hpTable = new Grid().Width(15).AddColumn();
        hpTable
            .AddRow(new Text($"Hit Points:").Centered())
            .AddRow(new Text($"{HitPoints}/{HitPoints}").Centered());

        Grid invHeader = new Grid().Width(25).AddColumn();
        invHeader
            .AddRow(new Text("Inventory:").RightJustified());

        Grid invTable = new Grid();
        invTable.AddColumn();

        if (Inventory.Items.Any() == true)
        {
            foreach (Item item in Inventory.Items)
            {
                invTable.AddRow(item.Name);
            }
        }
        else
        {
            invTable.AddRow("(No Items)");
        }

        Table displayTable = new Table();
        displayTable
            .AddColumn(new TableColumn(charTable))
            .AddColumn(new TableColumn(hpTable))
            .AddRow(invHeader, invTable);

        AnsiConsole.Write(displayTable);

    }

    public override string ToString()
    {
        return $"{Name},{Class},{Level},{HitPoints},{Inventory}";
    }
}
