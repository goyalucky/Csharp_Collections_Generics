namespace SmartWarehouseManagement{

// It is abstract, so it cannot be instantiated directly
abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    protected WarehouseItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    
    // Abstract method forces all child classes
    // to provide their own display implementation
    public abstract void Display();
    }
}