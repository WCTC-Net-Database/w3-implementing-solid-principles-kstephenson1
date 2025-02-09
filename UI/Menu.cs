using Spectre.Console;

namespace w3_assignment_ksteph.UI;

public abstract class Menu
{
    protected Table _table = new();
    protected List<MenuItem> _menuItems = new();

    public virtual void AddMenuItem(string name)
    {
        _menuItems.Add(new MenuItem(name));
    }

    public abstract void BuildTable();

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

