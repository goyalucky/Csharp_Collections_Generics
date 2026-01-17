/* Cab Driver Assignment System
Problem Statement - Assign cab drivers optimally.
Use:
● List<Driver>
● SortedList<double, Driver>

Tasks
1. Assign nearest available driver.
2. If distance same, choose highest rating.
3. Handle ride cancellation and reassignment.
4. Penalize drivers with frequent cancellations.

Edge Cases Students Miss
● No drivers available
● Equal distance & rating
● Driver becomes unavailable mid-assignment
● Floating-point comparison issues
● Reassigning same driver again */


using System;
using System.Collections.Generic;

namespace CabAssignmentSystem
{
    public class CabDriverMain
    {
        public static void Start()
        {
            // Driver list
            List<Driver> drivers = new List<Driver>
            {
                new Driver(1, "Amit", 4.7),
                new Driver(2, "Ravi", 4.9),
                new Driver(3, "Neha", 4.9)
            };

            // Driver distances from user
            Dictionary<int, double> distances = new Dictionary<int, double>
            {
                {1, 2.0},
                {2, 1.5},
                {3, 1.5}
            };

            // Assign cab
            Driver assigned = CabService.AssignDriver(drivers, distances);

            if (assigned == null)
                Console.WriteLine("No drivers available");
            else
                Console.WriteLine($"Assigned Driver: {assigned.Name}");

            // Simulate cancellation
            CabService.CancelRide(assigned);

            // Reassign cab
            Driver reassign = CabService.AssignDriver(drivers, distances);
            Console.WriteLine($"Reassigned Driver: {reassign?.Name}");
        }
    }
}