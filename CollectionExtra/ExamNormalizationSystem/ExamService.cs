using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamNormalizationSystem
{
    // Contains result normalization logic
    public class ExamService
    {
        // Add grace marks for borderline students
        public static void ApplyGrace(Dictionary<int, StudentResult> students)
        {
            foreach (var s in students.Values)
            {
                for (int i = 0; i < s.Marks.Count; i++)
                {
                    // Grace only if between 33 and 35
                    if (s.Marks[i] >= 33 && s.Marks[i] <= 35)
                        s.Marks[i] = 35;
                }
            }
        }

        // Normalize marks if class average is low
        public static void Normalize(Dictionary<int, StudentResult> students)
        {
            if (students.Count == 0) return;

            double avg = students.Values.Average(s => s.Total);

            // Increase marks if class average < 50
            if (avg < 50)
            {
                foreach (var s in students.Values)
                    s.Total += 5; // controlled inflation
            }
        }

        // Recalculate ranks after updates
        public static SortedDictionary<int, int> CalculateRanks(
            Dictionary<int, StudentResult> students)
        {
            SortedDictionary<int, int> ranks = new SortedDictionary<int, int>();

            var sorted = students.Values.OrderByDescending(s => s.Total).ThenBy(s => s.RollNo).ToList();

            int rank = 1;
            foreach (var s in sorted)
            {
                ranks[s.RollNo] = rank++;
            }

            return ranks;
        }

        // Detect abnormal inflation
        public static void DetectInflation(Dictionary<int, StudentResult> students)
        {
            Console.WriteLine("\nAbnormal Score Inflation:");

            foreach (var s in students.Values)
            {
                if (s.Total > 100)
                    Console.WriteLine($"Roll {s.RollNo}: Suspicious Total = {s.Total}");
            }
        }
    }
}
