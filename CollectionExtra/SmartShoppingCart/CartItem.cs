using System;

namespace SmartShoppingCart
{
    // Represents an item in the cart
public class CartItem
{
    public int Id;
    public string Name;
    public double Price;
    public int Quantity;

    public CartItem(int id, string name, double price, int qty)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = qty;
    }

    // Total price of this item
    public double TotalPrice()
    {
        return Price * Quantity;
    }
}
}