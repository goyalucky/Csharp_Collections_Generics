using System;
namespace SmartShoppingCart
{
    // Represents a discount offer
public class Offer
{
    public string Name;
    public Func<Dictionary<int, CartItem>, double> Apply;

    public Offer(string name, Func<Dictionary<int, CartItem>, double> apply)
    {
        Name = name;
        Apply = apply;
    }
}
}

