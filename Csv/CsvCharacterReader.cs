namespace w3_assignment_ksteph.Csv;

using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using w3_assignment_ksteph.Character;

public static class CsvCharacterReader
{  
    public static List<Character> Import(string path)
    {
        using StreamReader reader = new(path);
        using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

        IEnumerable<Character> characters = csv.GetRecords<Character>();

        return characters.ToList();
    }
}
