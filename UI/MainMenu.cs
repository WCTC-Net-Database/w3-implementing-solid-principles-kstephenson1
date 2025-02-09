using Spectre.Console;

namespace w3_assignment_ksteph.UI;

public class MainMenu : Menu
{

    public void AddMenuItem(int index, string name, string desc, Action action)
    {
        _menuItems.Add(new MainMenuItem(index, name, desc, action));
    }

    public override void BuildTable()
    {
        _table.AddColumn("#");
        _table.AddColumn("Selection");
        _table.AddColumn("Description");

        foreach (MainMenuItem item in _menuItems)
        {
            _table.AddRow(item.Index.ToString(), item.Name, item.Description);
        }
        _table.HideHeaders();
    }

    public void Action(int selection)
    {
        List<MainMenuItem> menuItems = new();
        foreach (MainMenuItem item in _menuItems)
        {
            menuItems.Add((MainMenuItem)item);
        }

        menuItems[selection - 1].Action();
    }
}

