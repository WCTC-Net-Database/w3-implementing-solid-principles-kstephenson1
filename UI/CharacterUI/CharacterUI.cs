using Spectre.Console;
using w3_assignment_ksteph.Characters;
using w3_assignment_ksteph.Inventories;

namespace w3_assignment_ksteph.UI;

public static class CharacterUI
{
    public static void DisplayCharacterInfo(Character character)
    {
        Grid charTable = new Grid().Width(25).AddColumn().RightAligned();
        charTable
            .AddRow(new Text(character.Name).Centered())
                .AddRow(new Text($"Level {character.Level} {character.Class}").Centered());

        Grid hpTable = new Grid().Width(15).AddColumn();
        hpTable
            .AddRow(new Text($"Hit Points:").Centered())
                .AddRow(new Text($"{character.HitPoints}/{character.HitPoints}").Centered());

        Grid invHeader = new Grid().Width(25).AddColumn();
        invHeader
            .AddRow(new Text("Inventory:").RightJustified());

        Grid invTable = new Grid();
        invTable.AddColumn();

        if (character.Inventory.Items.Any() == true)
        {
            foreach (Item item in character.Inventory.Items)
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
}
