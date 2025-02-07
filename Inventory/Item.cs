namespace w3_assignment_ksteph.Inventory;

public class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}
