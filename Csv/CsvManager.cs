namespace w3_assignment_ksteph.Csv;

public static class CsvManager
{
    private const string CHARACTER_PATH = "input.csv";
    
    public static void ImportCharacters() => CsvCharacterReader(CHARACTER_PATH)

    public static void ExportCharacters() => CsvCharacterWriter(CharacterManager.Characters, CHARACTER_PATH)
}
