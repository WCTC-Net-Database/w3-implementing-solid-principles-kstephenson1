namespace w3_assignment_ksteph.UI;
public class MainMenuItem : MenuItem
{
    public int Index { get; set; }
    public string Description { get; set; }
    public Action Action { get; set; }

    public MainMenuItem(int index, string name, string desc, Action action): base(name)
    {
        Index = index;
        Name = name;
        Description = desc;
        Action = action;
    }
}
