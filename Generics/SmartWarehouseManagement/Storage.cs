using System.Collections.Generic;

namespace SmartWarehouseManagement
{
    // Generic storage class that can store any warehouse item
class Storage<T> where T : WarehouseItem
{
    // internal List to hold items safely
    private List<T> items = new List<T>();

    // Add new itemS to storage
    public void AddItem(T item)
    {
        items.Add(item);
    }
    // Returns items as IEnumerable
    public IEnumerable<T> GetItems()
    {
        return items;
    }
}
}