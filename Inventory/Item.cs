using w3_assignment_ksteph.DataHelper;

namespace w3_assignment_ksteph.Inventory;

public class Item
{
    public string Name { get; set; }
    public string ID { get; set; }

    public Item(string id)
    {
        ID = StringHelper.ToItemIdFormat(id);
        Name = StringHelper.ToItemNameFormat(id);
    }

    public Item(string id, string name)
    {
        ID = StringHelper.ToItemIdFormat(id);
        Name = StringHelper.ToItemNameFormat(name);
    }

    public override string ToString()
    {
        return ID;
    }
}
