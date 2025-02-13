using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace w3_assignment_ksteph.Csv;

// The InventoryConverter is used to turn the inventory string into an Inventories Object automatically.
public class InventoryConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        return InventorySerializer.Deserialize(text!);
    }
}
