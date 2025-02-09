namespace w3_assignment_ksteph.Csv;

public static class CsvManager
{
    public Character CsvToCharacter(CsvCharacterIO csvCharacter)
    {
        return new(csvCharacter.Name, csvCharacter.Class, csvCharacter.Level, csvCharacter.HitPoints, InventoryManager.ToInventory(csvCharacter.Inventory));
    }

    public CsvCharacterIO CharactertoCsv(Character character)
    {
        return new(character.Name, character.Class, character.Level, character.HitPoints, InventoryManager.ToString(character.Inventory));
    }
    
    public static void ImportCharacters(string path) => CsvCharacterReader(path)
    public static void ExportCharacters(List<Character> characters, string path) => CsvCharacterWriter(characters, path)
}
