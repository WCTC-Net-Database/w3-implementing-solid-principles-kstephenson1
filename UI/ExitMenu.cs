using Spectre.Console;
using System.Data;

namespace w3_assignment_ksteph.UI;

public class ExitMenu : Menu
{

    public override void BuildTable()
    {
        _table.AddColumn("Header");

        foreach (MenuItem item in _menuItems)
        {
            _table.AddRow(item.Name);
        }
        _table.HideHeaders();
    }

}

