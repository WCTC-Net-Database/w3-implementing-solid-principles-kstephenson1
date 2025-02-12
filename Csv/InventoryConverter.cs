namespace w3_assignment_ksteph.Csv;

// The InventoryConverter is used to turn the csv string into an Inventory Object
public class InventoryConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IRowReaderRow row, MemberMapData memberMapData)
    {
        return InventoryManager.ToInventory(text);
    }
}
