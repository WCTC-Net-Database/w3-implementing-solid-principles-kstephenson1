using w3_assignment_ksteph.Character;

namespace w3_assignment_ksteph.UI;

// The UI class contains elements for the UI including the main menu and the exit message.
public static class UserInterface
{
    public static MainMenu MainMenu { get; private set; } = new();
    public static Menu ExitMenu { get; private set; } = new();

    public static void BuildMenus()
    {
        BuildMainMenu();
        BuildExitMenu();
    }

    private static void BuildMainMenu()
    {
        MainMenu = new();
        MainMenu.AddMenuItem(1, "Display All Characters", "Displays all characters and items in their inventory.", CharacterManager.DisplayAllCharacters);
        MainMenu.AddMenuItem(2, "Find Character", "Finds an existing character by name.", CharacterManager.FindCharacter);
        MainMenu.AddMenuItem(3, "New Character", "Creates a new character.", CharacterManager.NewCharacter);
        MainMenu.AddMenuItem(4, "Level Up Chracter", "Levels an existing character.", CharacterManager.LevelUp);
        MainMenu.AddMenuItem(5, "Exit", "Ends the program.", null);
        MainMenu.BuildTable();
    }

    private static void BuildExitMenu()
    {
        ExitMenu = new();
        ExitMenu.AddMenuItem("Thank you for using the RPG Character Editor.");
        ExitMenu.BuildTable();
    }
}
