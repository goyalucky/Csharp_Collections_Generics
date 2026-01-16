namespace SmartWarehouseManagement
{
    // It inherits common properties from WarehouseItem
    class Electronics : WarehouseItem
    {
     // Constructor passes values to base class constructor
    public Electronics(string name, int quantity): base(name, quantity) { }

    public override void Display()
    {
        Console.WriteLine($"Electronics: {Name}, Quantity: {Quantity}");
    }
 }
}
