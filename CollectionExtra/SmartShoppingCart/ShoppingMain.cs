/* Smart Shopping Cart System
Problem Statement - Build a shopping cart system using collections.
Use:
● Dictionary<int, CartItem> for cart
● List<Offer> for discount rules
Tasks
1. Add items to cart (increase quantity if already present).
2. Apply offers:
    ○ Buy 2 Get 1 (same product)
    ○ 10% discount if total > ₹5000
    ○ Free delivery if item count ≥ 5
3. Apply only one best offer.
4. Generate final bill with breakdown.

Edge Cases
● Cart value exactly ₹5000
● Multiple offers applicable simultaneously
● Buy 2 Get 1 when quantity = 2
● Removing item reduces eligibility
● Empty cart checkout */

using System;

namespace SmartShoppingCart
{
   public class ShoppingMain
{
    public static void Start()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.LoadOffers();

        cart.AddItem(new CartItem(1, "Laptop", 45000, 1));
        cart.AddItem(new CartItem(2, "Mouse", 500, 3));
        cart.AddItem(new CartItem(3, "Keyboard", 1500, 1));
        cart.Checkout();
    }
}
}