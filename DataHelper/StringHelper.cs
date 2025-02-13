using System.Globalization;

namespace w3_assignment_ksteph.DataHelper;

// The DataHelper.StringFuctions class contains string manipulation methods.
class StringHelper
{
    /// <summary>
    /// Takes the string and returns a variant in Titlecase
    /// </summary>
    /// <param name="input">The string to be converted to Titlecase</param>
    /// <returns>Uppercase <strong>String</strong> provided by the user.</returns>
    public static string ToTitleCase(string input) => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(input);
}
