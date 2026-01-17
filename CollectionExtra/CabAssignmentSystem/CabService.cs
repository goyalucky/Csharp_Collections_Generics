using System;
using System.Collections.Generic;

namespace CabAssignmentSystem
{
    // Handles driver assignment logic
    public class CabService
    {
        private const int MAX_CANCELS = 3;

        // Assign nearest available driver
        public static Driver AssignDriver(
            List<Driver> drivers,
            Dictionary<int, double> distances)
        {
            // Stores drivers sorted by distance
            SortedList<double, List<Driver>> sorted =
                new SortedList<double, List<Driver>>();

            foreach (var d in drivers)
            {
                // Skip unavailable or penalized drivers
                if (!d.IsAvailable || d.CancelCount >= MAX_CANCELS)
                    continue;

                double dist = Math.Round(distances[d.Id], 3); // avoid float issues

                if (!sorted.ContainsKey(dist))
                    sorted[dist] = new List<Driver>();

                sorted[dist].Add(d);
            }

            if (sorted.Count == 0)
                return null;

            // Pick nearest distance
            foreach (var entry in sorted)
            {
                Driver best = entry.Value[0];

                // Choose highest-rated if distance same
                foreach (var d in entry.Value)
                {
                    if (d.Rating > best.Rating)
                        best = d;
                }

                best.IsAvailable = false;
                return best;
            }

            return null;
        }

        // Handle ride cancellation
        public static void CancelRide(Driver driver)
        {
            driver.CancelCount++;

            // Penalize frequent cancellations
            driver.IsAvailable = driver.CancelCount < MAX_CANCELS;
        }
    }
}
