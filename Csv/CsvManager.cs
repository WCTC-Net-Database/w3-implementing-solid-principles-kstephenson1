namespace w3_assignment_ksteph.Csv;

public static class CsvManager
{
    public static void ImportCharacters(string path) => CsvCharacterReader(path)
    public static void ExportCharacters(List<Character> characters, string path) => CsvCharacterWriter(characters, path)
}
