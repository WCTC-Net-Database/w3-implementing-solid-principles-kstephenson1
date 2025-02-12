namespace w3_assignment_ksteph.Csv;

using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Config;

public static class CsvCharacterWriter
{

    public static void Export(List<Character> characters, string path)
    {
        List<Character> outputCharacters = new();

        // Checks the Config to determine whether or not to add double quotes to the csv writer output.
        CsvConfiguration config;
        if (Config.CSV_CHARACTER_WRITER_QUOTES_ON_EXPORT)
        {
            config = new CsvConfiguration(CultureInfo.InvariantCulture) { ShouldQuote = args => true };
        }
        else
        {
            config = new CsvConfiguration(CultureInfo.InvariantCulture);
        }
            
        using StreamWriter writer = new(path);
        using CsvWriter csvOut = new(writer, config);
        
        csvOut.WriteRecords(characters);
    }
}
