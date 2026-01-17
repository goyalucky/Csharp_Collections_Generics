using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryFineSystem
{
    // Handles fine calculation logic
    public class FineService
    {
        private const int MAX_FINE = 500;

        // Calculate fine for one book
        public static int CalculateFine(IssueRecord record)
        {
            // Returned on or before due date
            if (record.ReturnDate <= record.DueDate)
                return 0;

            int fine = 0;
            DateTime date = record.DueDate.AddDays(1);

            while (date <= record.ReturnDate)
            {
                // Skip Sundays
                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    int daysLate = (date - record.DueDate).Days;

                    // Fine slab logic
                    fine += (daysLate <= 7) ? 2 : 5;
                }
                date = date.AddDays(1);
            }

            // Cap maximum fine
            return Math.Min(fine, MAX_FINE);
        }

        // Monthly fine report
        public static Dictionary<int, int> MonthlyReport(
            Dictionary<int, List<IssueRecord>> records, int month, int year)
        {
            Dictionary<int, int> report = new Dictionary<int, int>();

            foreach (var student in records)
            {
                int totalFine = 0;

                foreach (var r in student.Value)
                {
                    if (r.ReturnDate.Month == month && r.ReturnDate.Year == year)
                        totalFine += CalculateFine(r);
                }

                report[student.Key] = totalFine;
            }
            return report;
        }

        // Identify frequent defaulters
        public static List<int> FrequentDefaulters(
            Dictionary<int, List<IssueRecord>> records)
        {
            List<int> defaulters = new List<int>();

            foreach (var student in records)
            {
                // Count books returned late
                int lateCount = student.Value.Count(r => r.ReturnDate > r.DueDate);

                if (lateCount >= 3)
                    defaulters.Add(student.Key);
            }
            return defaulters;
        }
    }
}
