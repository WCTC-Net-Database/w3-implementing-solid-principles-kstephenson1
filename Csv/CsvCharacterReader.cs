namespace w3_assignment_ksteph.Csv;

using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using w3_assignment_ksteph.Character;

public static class CsvCharacterReader
{  
    public static List<Character> Import(string path)
    {

        List<Character> characters = new();
      
        using StreamReader reader = new(path);
        using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

        IEnumerable<CsvCharacterIO> csvCharacters = csv.GetRecords<CsvCharacterIO>();

        foreach (CsvCharacterIO csvCharacter in csvCharacters)
        {
            characters.Add(csvCharacter.ToCharacter());
        }

      return characters;
    }
}
