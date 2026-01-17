/* Inventory Reorder Prediction
Problem Statement Predict reorder requirement using sales data.
Use:● Dictionary<string, Queue<int>>

Tasks
1. Maintain last 7 days sales.
2. Calculate moving average.
3. Trigger reorder if avg sales > stock.
4. Predict stock-out date.

Edge Cases
● Less than 7 days of data
● Zero sales days
● Stock exactly equals average
● Queue overflow
● Negative stock values */

using System;

namespace InventoryPredictionSystem
{
    public class InventoryMain
    {
        public static void Start()
        {
            Product p = new Product("Laptop", 20);

            // Add last 7 days sales
            int[] sales = { 3, 4, 0, 5, 6, 4, 5 };

            foreach (int s in sales)
                InventoryService.AddSales(p, s);

            double avg = InventoryService.CalculateAverage(p);
            Console.WriteLine($"Average Sales: {avg:F2}");

            if (InventoryService.ShouldReorder(p))
                Console.WriteLine("Reorder required");
            else
                Console.WriteLine("Stock sufficient");

            var stockOut = InventoryService.PredictStockOut(p);

            if (stockOut != null)
                Console.WriteLine($"Predicted Stock-out Date: {stockOut.Value.ToShortDateString()}");
            else
                Console.WriteLine("Stock-out prediction not possible");
        }
    }
}
