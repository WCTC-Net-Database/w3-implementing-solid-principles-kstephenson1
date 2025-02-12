namespace w3_assignment_ksteph.Csv;

using System;
using System.Collections.Generic;

public class InventorySerializer
{
    public static void ListInventory(Inventory inventory)
    {
        ListInventory(ToString(inventory));
    }

    public static void ListInventory(string inventoryString) // Takes the inventory string, splits it, and displays the inventory to the user.
    {
        Console.WriteLine($"Inventory:");

        if (inventoryString == "" || inventoryString == null)
        {
            Console.WriteLine("    - (Empty)");
        }
        else
        {
            List<Item> items = ToItemList(inventoryString);

            foreach (Item item in items)
            {
                Console.WriteLine($"    - {item}");
            }

            Console.WriteLine("\n");
        }
    }

    public static List<Item> ToItemList(string itemString)
    {
        //Converts String into List<Item>
        List<Item> itemList = [];

        string[] items = itemString.Split('|');

        foreach (string item in items)
            itemList.Add(new Item(item));

        return itemList;
    }

    public static string ToString(List<Item> items)
    {
        // Converts List<Item> to String
        if (items == null)
            return "";
        else
        {
            string inventory = "";

            foreach (Item item in items)
            {
                if (inventory == "")
                    inventory += item.ToString();
                else
                    inventory += "|" + item.ToString();
            }

            return inventory;
        }
    }

    public static Inventory ToInventory(List<Item> itemList)
    {
        // Converts List<Item> to Inventory
        return new(itemList);
    }

    public static List<Item>? ToItemList(Inventory inventory)
    {
        // Converts Inventory to List<Item>
        return inventory.Items;
    }

    public static Inventory ToInventory(string inventoryString)
    {
        // Converts String into Inventory
        return ToInventory(ToItemList(inventoryString));
    }

    public static string ToString(Inventory inventory)
    {
        // Converts Inventory into String
        return ToString(ToItemList(inventory));
    }
}
