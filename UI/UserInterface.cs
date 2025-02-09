namespace w3_assignment_ksteph.UI;

// The UI class contains elements for the UI including the main menu and the exit message.
public static class UserInterface
{
    public static void MainMenu()
    {
        Console.WriteLine(
            "╔═════════════════════════╗\n" +
            "║        Main Menu        ║\n" +
            "╠═════════════════════════╣\n" +
            "║ 1. Display Characters   ║\n" +
            "║ 2. Find Character       ║\n" +
            "║ 3. New Character        ║\n" +
            "║ 4. Level Up Character   ║\n" +
            "║ 5. Exit                 ║\n" +
            "╚═════════════════════════╝\n");
    }

    public static void ExitMenu()
    {
        Console.Clear();
        Console.WriteLine(
            "\n\n\n\n\n\n\n\n\n" +
            "          ╔═════════════════════════════════════════════════════╗\n" +
            "          ║    Thank you for using the RPG Character Editor.    ║\n" +
            "          ╚═════════════════════════════════════════════════════╝\n" +
            "\n\n\n\n\n\n\n\n\n");
    }
}
