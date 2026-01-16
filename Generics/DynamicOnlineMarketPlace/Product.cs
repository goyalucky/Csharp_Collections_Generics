using System;
using System.Collections.Generic;

namespace DynamicOnlineMarketPlace
{
     // abstract class product
    public abstract class Product
    {
        public string? ProductName;
        private double price; // private data 
        // public getter and setter
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 100)
                {
                    System.Console.WriteLine("Price cannot less than 100.");
                    return;
                }
                price = value;
            }
        }
        public abstract void Display();

    }
    // generic class
    class Product<TCategory> : Product where TCategory : CategoryType
    {
        public TCategory? Category { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Product: {ProductName}, Price: {Price}, Category: {Category?.Name}");
        }
    }
}