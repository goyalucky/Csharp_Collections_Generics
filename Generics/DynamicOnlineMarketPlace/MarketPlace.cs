using System;
using System.Collections.Generic;

namespace DynamicOnlineMarketPlace
{
     public class MarketPlace
    {
        // List to store products
        private List<Product> catalog = new List<Product>(); 

        public void AddProduct(Product product)
        {
            catalog.Add(product);
        }

        public void DisplayCatalog()
        {
            foreach (var p in catalog)
            {
                p.Display();
            }
        }
    }
}