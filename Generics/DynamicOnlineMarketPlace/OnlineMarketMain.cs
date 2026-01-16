/* Dynamic Online Marketplace
o Concepts: Type Parameters, Generic Methods, Constraints
o Problem Statement: Build a generic product catalog for an online marketplace supporting various product types.
o Hints:
▪ Define a generic class Product<T> where T is restricted to a category (BookCategory, ClothingCategory).
▪ Implement a generic method void ApplyDiscount<T>(T product, double percentage) where T : Product.
▪ Ensure type safety while allowing multiple product categories in the catalog. */

using System;
using System.Collections.Generic;

namespace DynamicOnlineMarketPlace
{
     public class MarketPlaceMain
    {
        public static void Execute()
        {
            Product<BookCategory> book = new Product<BookCategory>
            {
                ProductName = "C# language",
                Price = 432,
                Category = new BookCategory()
            };

            Product<ClothingCategory> cloth = new Product<ClothingCategory>
            {
                ProductName = "Shirt",
                Price = 1400,
                Category = new ClothingCategory()
            };

            DiscountFacility.ApplyDiscount(book, 10);
            DiscountFacility.ApplyDiscount(cloth, 20);

            MarketPlace market = new MarketPlace();
            market.AddProduct(book);
            market.AddProduct(cloth);

            market.DisplayCatalog();
        }
    }
}