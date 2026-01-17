/* Online Exam Result Normalization
Problem Statement - Normalize exam results based on performance.
Use:
● Dictionary<int, List<int>>
● SortedDictionary<int, int>

Tasks
1. Add grace marks if: ○ Score between 33–35
2. Normalize marks if class average < 50.
3. Recalculate ranks.
4. Detect abnormal score inflation.

Edge Cases Students Miss
● Marks exceeding maximum limit
● Multiple students with same marks
● Rank recalculation after update
● Student already passed before grace
● Empty subject list */


using System;
using System.Collections.Generic;

namespace ExamNormalizationSystem
{
    public class ExamMain
    {
        public static void Start()
        {
            Dictionary<int, StudentResult> students = new Dictionary<int, StudentResult>();
            students[1] = new StudentResult(1, new List<int> { 34, 45, 50 });
            students[2] = new StudentResult(2, new List<int> { 30, 60, 55 });
            students[3] = new StudentResult(3, new List<int> { 35, 35, 35 });

            // Initial totals
            foreach (var s in students.Values)
                s.CalculateTotal(100);

            // Apply grace marks
            ExamService.ApplyGrace(students);

            // Recalculate totals after grace
            foreach (var s in students.Values)
                s.CalculateTotal(100);

            // Normalize class results
            ExamService.Normalize(students);

            // Generate ranks
            var ranks = ExamService.CalculateRanks(students);

            Console.WriteLine("Final Ranks:");
            foreach (var r in ranks)
                Console.WriteLine($"Roll {r.Key} → Rank {r.Value}");

            // Detect abnormal inflation
            ExamService.DetectInflation(students);
        }
    }
}