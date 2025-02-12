using w3_assignment_ksteph.Csv;

namespace w3_assignment_ksteph.Inventory;
public class Inventory
{
    public List<Item>? Items { get; set; } = new();

    public Inventory() { }
    public Inventory(List<Item> items)
    {
        Items = items;
    }

    public override string ToString() => InventorySerializer.Serialize(this)!;
}
