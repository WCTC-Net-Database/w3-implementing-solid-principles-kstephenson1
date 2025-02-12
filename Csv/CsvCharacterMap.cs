namespace w3_assignment_ksteph.Csv;

// The Character Map is used to convert character information from csv format to a Character object.
public class CsvCharacterMap : CsvClassMap<Character>
{
    public CsvCharacterMap()
    {
        InventoryConverter inventoryConveter = new InventoryConverter()
    
        Map(character => character.Name);
        Map(character => character.Class);
        Map(character => character.Level);
        Map(character => character.HitPoints);
        Map(character => character.Inventory).TypeConverter(inventoryConverter);
    }
}
