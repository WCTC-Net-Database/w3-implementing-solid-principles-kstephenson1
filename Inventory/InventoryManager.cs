﻿namespace w3_assignment_ksteph.Inventories;

using w3_assignment_ksteph.UI;

public class InventoryManager
{
    // InventoryManager holds methods that have to do with manipulating inventories.
    [Obsolete]
    public static void ListInventory(Inventory inventory) => InventoryUI.DisplayInventory(inventory);
}
