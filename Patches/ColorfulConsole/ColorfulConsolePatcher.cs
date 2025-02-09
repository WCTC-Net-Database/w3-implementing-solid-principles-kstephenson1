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
         * the built in console colors instead of this package.
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
