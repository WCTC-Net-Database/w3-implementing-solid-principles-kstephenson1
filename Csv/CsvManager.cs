namespace w3_assignment_ksteph.Csv;

using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.DataHelper;
using w3_assignment_ksteph.Inventory;

public static class CsvManager
{
    private const string CHARACTER_PATH = "input.csv";
    public static void ImportCharacters()
    {
        using StreamReader reader = new(CHARACTER_PATH);
        using CsvReader csv = new(reader, CultureInfo.InvariantCulture);

        IEnumerable<CsvCharacterIO> csvCharacters = csv.GetRecords<CsvCharacterIO>();

        foreach (CsvCharacterIO csvCharacter in csvCharacters)
        {
            CharacterManager.AddCharacter(csvCharacter.ToCharacter());
        }
    }

    public static void ExportCharacters()
    {
        using StreamWriter writer = new(CHARACTER_PATH);
        using CsvWriter csvOut = new(writer, CultureInfo.InvariantCulture);

        csvOut.WriteRecords(CharacterManager.Characters);

        foreach (Character character in CharacterManager.Characters)
        {
            csvOut.WriteRecords(character.ToCsvCharacterIO());
        }
    }
}
