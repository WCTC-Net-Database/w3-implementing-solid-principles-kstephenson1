namespace w3_assignment_ksteph;

using System;
using System.Drawing;
using Console = Colorful.Console;
using DataHelper;
using System.Diagnostics;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Csv;

class Program
{
    static void Main()
    {
        ColorBugCorrector();
        Initiation();
        Run();
        End();
    }

    public static void Initiation()
    {
        CsvManager.ImportCharacters();
    }

    public static void Run()
    {
        // Will run until exit is selected
        while (true)
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
        CsvManager.ExportCharacters();
        UserInterface.ExitMenu();
    }

    private static void ColorBugCorrector()
    {
        /*
         * Colorful.Console has a bug that results in the colors being generated in an specific order instead of as named.
         * This NuGet package is broken but this line of code seems to fix the colors.  I would be better off using the
         * built in console colors instead of this package.
         */

        Console.WriteLine("", Color.Blue);
        Console.WriteLine("", Color.Green);
        Console.WriteLine("", Color.Cyan);
        Console.WriteLine("", Color.Red);
        Console.WriteLine("", Color.Purple);
        Console.WriteLine("", Color.Yellow);
        Console.WriteLine("", Color.White);
        Console.WriteLine("", Color.Gray);
        Console.WriteLine("", Color.LightBlue);
        Console.WriteLine("", Color.LightGreen);
        Console.WriteLine("", Color.Teal);
        Console.WriteLine("", Color.Pink);
        Console.WriteLine("", Color.Magenta);
        Console.Clear();
        Console.Clear();
    }
}