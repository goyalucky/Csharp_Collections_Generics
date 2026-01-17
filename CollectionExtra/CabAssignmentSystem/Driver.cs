using System;

namespace CabAssignmentSystem
{
    // Represents a cab driver
    public class Driver
    {
        public int Id;
        public string Name;
        public double Rating;
        public bool IsAvailable;
        public int CancelCount;

        // Initialize driver details
        public Driver(int id, string name, double rating)
        {
            Id = id;
            Name = name;
            Rating = rating;
            IsAvailable = true;
            CancelCount = 0;
        }
    }
}
