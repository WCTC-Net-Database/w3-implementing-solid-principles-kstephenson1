
using CsvHelper;
using w3_assignment_ksteph.Character;
using w3_assignment_ksteph.Csv;
using CsvHelper.Configuration;

namespace w3_assignment_ksteph.Csv;
// The Character Map is used to convert character information from csv format to a Character object.
public class CsvCharacterMap : ClassMap<Character.Character>
{
    public CsvCharacterMap()
    {
        InventoryConverter inventoryConverter = new InventoryConverter();
    
        Map(character => character.Name);
        Map(character => character.Class);
        Map(character => character.Level);
        Map(character => character.HitPoints);
        Map(character => character.Inventory).TypeConverter(inventoryConverter);
    }
}
