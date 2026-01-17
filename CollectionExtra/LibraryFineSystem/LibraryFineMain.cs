/* Library Fine Calculation Engine
Problem Statement
Calculate fines for late book returns. Use:● Dictionary<int, List<IssueRecord>>
Tasks
1. Fine rules:
    ○ ₹2/day for first 7 days
    ○ ₹5/day after
    ○ No fine on Sundays
    ○ Max fine ₹500
2. Generate monthly fine report.
3. Identify frequent defaulters.

Edge Cases
● Book returned on Sunday
● Return before due date
● Fine exceeding cap
● Month boundary calculation
● Multiple books per student   */

using System;
using System.Collections.Generic;

namespace LibraryFineSystem
{
    public class Program
    {
       public static void Start()
        {
            Dictionary<int, List<IssueRecord>> data =
                new Dictionary<int, List<IssueRecord>>();

            // Student 101
            data[101] = new List<IssueRecord>
            {
                new IssueRecord(1,
                    new DateTime(2025, 1, 10),
                    new DateTime(2025, 1, 20)),

                new IssueRecord(2,
                    new DateTime(2025, 1, 5),
                    new DateTime(2025, 1, 5))
            };

            // Student 102
            data[102] = new List<IssueRecord>
            {
                new IssueRecord(3,
                    new DateTime(2025, 1, 1),
                    new DateTime(2025, 2, 1))
            };

            // Generate monthly report
            var report = FineService.MonthlyReport(data, 1, 2025);

            Console.WriteLine("January Fine Report:");
            foreach (var r in report)
                Console.WriteLine($"Student {r.Key} → Fine ₹{r.Value}");

            // Frequent defaulters
            var defaulters = FineService.FrequentDefaulters(data);

            Console.WriteLine("\nFrequent Defaulters:");
            foreach (var id in defaulters)
                Console.WriteLine($"Student {id}");
        }
    }
}
