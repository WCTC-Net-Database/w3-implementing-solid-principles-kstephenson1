namespace w3_assignment_ksteph.Patches.ColorfulConsole;

using System;
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
    }
}
