namespace w3_assignment_ksteph.Csv;

using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using w3_assignment_ksteph.Character;

public static class CsvCharacterWriter
{

    public static void Export(List<Character> characters, string path)
    {
        using StreamWriter writer = new(path);
        using CsvWriter csvOut = new(writer, CultureInfo.InvariantCulture);

        foreach (Character character in characters)
        {
            csvOut.WriteRecords(character.ToCsvCharacterIO());
        }
    }
}
