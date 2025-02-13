using w3_assignment_ksteph.DataHelper;

namespace w3_assignment_ksteph.Inventory;

public class Item
{
    public string Name { get; set; }
    public string ID { get; set; }

    public Item(string id)
    {
        ID = id.ToLower();
        Name = StringHelper.ToTitleCase(id);
    }

    public override string ToString()
    {
        return ID;
    }
}
