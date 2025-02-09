namespace w3_assignment_ksteph;

using DataHelper;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Patches.ColorfulConsole;

class Program
{
    static void Main()
    {
        Initiation();
        Run();
        End();
    }

    public static void Initiation()
    {
        ColorfulConsolePatcher.ColorBugPatch(); // Colorful.Console patch that fixes the incorrect colors showing on newer windows machines.
        CharacterManager.ImportCharacters(); //Imports the caracters from the csv file.
    }

    public static void Run()
    {
        while (true) // Will run until exit is selected
        {
            UserInterface.MainMenu();

            int selection = Input.GetInt(1, 5, "Value must be between 1-5"); // Uses a helper file to get an int between 1-5 from the user

            if (selection == 5) break; // Exits the program if '5' is selected.

            switch (selection) // Checks the input from the user and responds appropriately.
            {
                case 1:
                    CharacterManager.DisplayAllCharacters();
                    break;
                case 2:
                    CharacterManager.FindCharacter();
                    break;
                case 3:
                    CharacterManager.NewCharacter();
                    break;
                case 4:
                    CharacterManager.LevelUp();
                    break;

            }
        }
    }

    public static void End()
    {
        CharacterManager.ExportCharacters(); //Outputs the characters into the csv file.
        UserInterface.ExitMenu(); //Shows the exit menu and leaves the program.
    }

    
}
