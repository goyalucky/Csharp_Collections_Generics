using System;
using System.Collections.Generic;

namespace DynamicOnlineMarketPlace
{
     public class DiscountFacility
    {
        // Method for applying discount on a product
        public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
        {
            product.Price -= product.Price * (percentage / 100);
        }
    }
}