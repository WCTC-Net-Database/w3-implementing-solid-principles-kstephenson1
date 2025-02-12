namespace w3_assignment_ksteph.Inventory;

using System;
using System.Collections.Generic;
using w3_assignment_ksteph.Csv;

public class InventoryManager
{
    public static void ListInventory(Inventory inventory) => InventorySerializer.ListInventory(inventory);
}
