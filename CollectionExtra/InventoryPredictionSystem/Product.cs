using System.Collections.Generic;

namespace InventoryPredictionSystem
{
    // Represents a product and its stock
    public class Product
    {
        public string Name;
        public int Stock;

        // Stores last 7 days sales
        public Queue<int> SalesHistory;

        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock < 0 ? 0 : stock;   // prevent negative stock
            SalesHistory = new Queue<int>();
        }
    }
}
