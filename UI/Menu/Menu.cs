using Spectre.Console;

namespace w3_assignment_ksteph.UI;

public class Menu
{
    // The Menu class is an abstract class to build other menus off of.  The Menu class holds a table which is part of the user interface
    // which is displayed to the user.  The Menu also holds menu items, which can store different types of data.
    protected Table _table = new();
    protected List<MenuItem> _menuItems = new();

    public virtual void AddMenuItem(string name)
    {
        _menuItems.Add(new MenuItem(name));
    }

    public virtual void BuildTable()
    {
        _table.AddColumn("Header");

        foreach (MenuItem item in _menuItems)
        {
            _table.AddRow(item.Name);
        }
        _table.HideHeaders();
    }

    public virtual void Show()
    {
        AnsiConsole.Write(_table);
    }

    public virtual void Show(bool clearConsole)
    {
        if (clearConsole)
            Console.Clear();

        AnsiConsole.Write(_table);
    }
}

