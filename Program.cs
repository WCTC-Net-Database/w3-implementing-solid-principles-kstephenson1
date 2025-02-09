
using w3_assignment_ksteph.DataHelper;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Patches.ColorfulConsole;
using w3_assignment_ksteph.UI;
using Spectre.Console;

namespace w3_assignment_ksteph;

class Program
{
    static void Main()
    {
        Initiation();
        //Test();
        Run();
        End();
    }

    public static void Initiation()
    {
        UserInterface.BuildMenus();
        ColorfulConsolePatcher.ColorBugPatch(); // Colorful.Console patch that fixes the incorrect colors showing on newer windows machines.
        CharacterManager.ImportCharacters(); //Imports the caracters from the csv file.
    }

    public static void Run()
    {
        while (true) // Will run until exit is selected
        {
            UserInterface.MainMenu.Show();

            int selection = Input.GetInt(1, 5, "Value must be between 1-5"); // Uses a helper file to get an int between 1-5 from the user

            if (selection == 5) break; // Exits the program if '5' is selected.

            UserInterface.MainMenu.Action(selection);
        }
    }

    public static void End()
    {
        CharacterManager.ExportCharacters(); //Outputs the characters into the csv file.
        UserInterface.ExitMenu.Show(true); //Shows the exit menu and leaves the program.
    }

    public static void Test()
    {
        //AnsiConsole.Markup("[underline red]Hello[/] World!\n");

        //// Create a table
        //var table = new Table();

        //// Add some columns
        //table.AddColumn("Foo");
        //table.AddColumn(new TableColumn("Bar").Centered());

        //// Add some rows
        //table.AddRow("Baz", "[green]Qux[/]");
        //table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

        //// Render the table to the console
        //AnsiConsole.Write(table);

        //Table mainMenu = new Table();
        //mainMenu.AddColumn("#");
        //mainMenu.AddColumn("Selection");
        //mainMenu.AddColumn("Description");

        //mainMenu.AddRow("1", "Display Characters", "Displays all characters");
        //mainMenu.AddRow("2", "Find Character", "Finds a character's info by using a name.");
        //mainMenu.AddRow("3", "Add Character", "Adds a new character");
        //mainMenu.AddRow("4", "Level Up Character", "Increases a character's level by one");
        //mainMenu.AddRow("5", "Exit", "Exits the program");

        //AnsiConsole.Write(mainMenu);

        //UserInterface.MainMenu.Show();
        //UserInterface.MainMenu.Action(1);
    }

}
