using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartShoppingCart
{
    // Handles cart operations
public class ShoppingCart
{
    Dictionary<int, CartItem> cart = new Dictionary<int, CartItem>();
    List<Offer> offers = new List<Offer>();

    // Add item or increase quantity
    public void AddItem(CartItem item)
    {
        if (cart.ContainsKey(item.Id))
            cart[item.Id].Quantity += item.Quantity;
        else
            cart[item.Id] = item;
    }

    // Register all offers
    public void LoadOffers()
    {
        // Buy 2 Get 1
        offers.Add(new Offer("Buy 2 Get 1", c =>
        {
            double discount = 0;
            foreach (var item in c.Values)
                if (item.Quantity >= 3)
                    discount += item.Price;
            return discount;
        }));

        // 10% off if total > 5000
        offers.Add(new Offer("10% Discount", c =>
        {
            double total = c.Values.Sum(i => i.TotalPrice());
            return total > 5000 ? total * 0.10 : 0;
        }));

        // Free delivery (₹100 assumed)
        offers.Add(new Offer("Free Delivery", c =>
        {
            int count = c.Values.Sum(i => i.Quantity);
            return count >= 5 ? 100 : 0;
        }));
    }

    // Checkout and bill generation
    public void Checkout()
    {
        if (cart.Count == 0)
        {
            Console.WriteLine("Cart is empty.");
            return;
        }

        double total = cart.Values.Sum(i => i.TotalPrice());

        // Choose best offer
        Offer bestOffer = null;
        double maxDiscount = 0;
        foreach (var offer in offers)
        {
            double d = offer.Apply(cart);
            if (d > maxDiscount)
            {
                maxDiscount = d;
                bestOffer = offer;
            }
        }

        // Bill breakdown
        foreach (var item in cart.Values)
        {
            Console.WriteLine($"{item.Name} x{item.Quantity} = {item.TotalPrice()}");
        }
        Console.WriteLine($"Subtotal: {total}");

        if (bestOffer != null && maxDiscount > 0)
            Console.WriteLine($"Offer Applied: {bestOffer.Name} ({maxDiscount})");

        Console.WriteLine($"Final Amount:{total - maxDiscount}");
    }
}
}