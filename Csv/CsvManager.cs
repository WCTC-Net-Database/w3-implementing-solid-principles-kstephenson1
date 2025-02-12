namespace w3_assignment_ksteph.Csv;

using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Inventory;

public static class CsvManager
{
    public static List<Character> ImportCharacters(string path) => CsvCharacterReader.Import(path);
    public static void ExportCharacters(List<Character> characters, string path) => CsvCharacterWriter.Export(characters, path);
}
