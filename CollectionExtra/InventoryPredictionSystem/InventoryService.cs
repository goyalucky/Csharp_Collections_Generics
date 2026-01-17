using System;
using System.Linq;

namespace InventoryPredictionSystem
{
    // Handles reorder prediction logic
    public class InventoryService
    {
        private const int MAX_DAYS = 7;

        // Add daily sales data
        public static void AddSales(Product product, int sales)
        {
            // Ignore negative sales
            product.SalesHistory.Enqueue(Math.Max(0, sales));

            // Maintain only last 7 days
            if (product.SalesHistory.Count > MAX_DAYS)
                product.SalesHistory.Dequeue();
        }

        // Calculate moving average
        public static double CalculateAverage(Product product)
        {
            if (product.SalesHistory.Count == 0)
                return 0;

            return product.SalesHistory.Average();
        }

        // Check if reorder is required
        public static bool ShouldReorder(Product product)
        {
            double avg = CalculateAverage(product);

            // Trigger reorder only if avg > stock
            return avg > product.Stock;
        }

        // Predict stock-out date
        public static DateTime? PredictStockOut(Product product)
        {
            double avg = CalculateAverage(product);

            // Cannot predict with zero sales
            if (avg <= 0 || product.Stock <= 0)
                return null;

            int days = (int)Math.Ceiling(product.Stock / avg);

            return DateTime.Today.AddDays(days);
        }
    }
}
