namespace SmartWarehouseManagement
{
    // Demonstrates inheritance and polymorphism
   class Groceries : WarehouseItem
{
    public Groceries(string name, int quantity): base(name, quantity) { }

// Overridden method provides specific display logic
    public override void Display()
    {
        Console.WriteLine($"Groceries: {Name}, Quantity: {Quantity}");
    }
 }
}