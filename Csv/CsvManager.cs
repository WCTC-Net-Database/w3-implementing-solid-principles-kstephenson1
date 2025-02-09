namespace w3_assignment_ksteph.Csv;

using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Inventory;

public static class CsvManager
{
    public static Character CsvToCharacter(CsvCharacterIO csvCharacter)
    {
        return new(csvCharacter.Name, csvCharacter.Class, csvCharacter.Level, csvCharacter.HitPoints, InventoryManager.ToInventory(csvCharacter.Inventory));
    }

    public static CsvCharacterIO CharactertoCsv(Character character)
    {
        return new() { Name = character.Name, Class = character.Class, Level = character.Level, HitPoints = character.HitPoints, Inventory = InventoryManager.ToString(character.Inventory), };
    }
    
    public static List<Character> ImportCharacters(string path) => CsvCharacterReader.Import(path);
    public static void ExportCharacters(List<Character> characters, string path) => CsvCharacterWriter.Export(characters, path);
}
