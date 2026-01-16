using System;
using System.Collections.Generic;
namespace SmartWarehouseManagement
{
public class SmartWareMain
{
    public static void Run()
    {
        // Storage for electronics
        Storage<Electronics> electronicsStore = new Storage<Electronics>();
        electronicsStore.AddItem(new Electronics("Earbuds", 10));
        electronicsStore.AddItem(new Electronics("SmartPhone", 20));

        // Storage for Groceries
        Storage<Groceries> groceryStore = new Storage<Groceries>();
        groceryStore.AddItem(new Groceries("fruits", 50));
        groceryStore.AddItem(new Groceries("Pasta", 30));

        // Storage for Furniture
        Storage<Furniture> furnitureStore = new Storage<Furniture>();
        furnitureStore.AddItem(new Furniture("Table", 15));

        // Display all items categories using a common method
        DisplayItems(electronicsStore.GetItems());
        DisplayItems(groceryStore.GetItems());
        DisplayItems(furnitureStore.GetItems());
    }
    
    // Accepts IEnumerable of base type (WarehouseItem)
    // Demonstrates variance and runtime polymorphism
    static void DisplayItems(IEnumerable<WarehouseItem> items)
    {
        foreach (var item in items)
        {
            item.Display();
        }
        Console.WriteLine();
    }
}
}