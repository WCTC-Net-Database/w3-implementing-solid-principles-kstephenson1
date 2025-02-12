namespace w3_assignment_ksteph.Patches.ColorfulConsole;

using System.Drawing;
using Console = Colorful.Console;

public class ColorfulConsolePatcher
{
    public static void ColorBugPatch()
    {
        /*
         * Colorful.Console has a bug that results in the colors being generated in an specific order instead of as named.
         * This NuGet package is broken but this line of code seems to fix the colors.  After some testing, for some reason,
         * after initially using the colors in this exact specific order seems to fix the issue.  I would be better off using
         * the built in console colors instead of this package.  The issue seems to have something to do with Windows 11 Update 22H.
         *
         * For example in this sample:
         *     Console.WriteLine("Line 1",Color.Red);
         *     Console.WriteLine("Line 2",Color.White);
         *     Console.WriteLine("Line 3",Color.Blue);
         *     Console.WriteLine("Line 4",Color.Red);
         *
         * Line 1 would show as Blue, Line 2 would show as Green, and Line 3 would show as Cyan, and Line 4 would be Blue because it
         * was already assigned.  Whatever color you use first gets assigned the color Blue, the second used color is always Green,
         * and etc.  Using these colors in the correct order at the beginning of the program seems to fix the issue enough for use
         * in this program.
         */

        List<Color> colors = new()
        {   
            Color.Blue,         Color.Green,        Color.Cyan,     Color.Red,
            Color.Purple,       Color.Yellow,       Color.White,    Color.Gray,
            Color.LightBlue,    Color.LightGreen,   Color.Teal,     Color.Pink,
            Color.Magenta
        };

        foreach (Color color in colors)
        {
            Console.Write("", color);
        }

        Console.Clear();
    }
}
