namespace SmartWarehouseManagement
{
    // Represents furniture items stored in the warehouse
   class Furniture : WarehouseItem
{
    public Furniture(string name, int quantity): base(name, quantity) { }

// display logic for furniture
    public override void Display()
    {
        Console.WriteLine($"Furniture: {Name}, Quantity: {Quantity}");
    }
}
}
