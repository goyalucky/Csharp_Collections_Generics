using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentPerformanceAnalyzer
{
    // Handles student performance analysis
public class PerformanceAnalyzer
{
    // Calculates average marks safely
    public static double GetAverage(List<int> marks)
    {
        if (marks == null || marks.Count == 0)
            return 0;
        return marks.Average();
    }

    // Checks pass condition
    public static bool HasPassed(List<int> marks)
    {
        if (marks == null || marks.Count == 0)
            return false;

        double avg = GetAverage(marks);
        bool subjectFail = marks.Any(m => m < 30);

        return avg >= 40 && !subjectFail;
    }

    // Finds top scorer per subject
    public static void DisplayTopScorers(Dictionary<int, List<int>> marks)
    {
        if (marks.Count == 0) return;

        int maxSubjects = marks.Values.Max(m => m.Count);

        for (int i = 0; i < maxSubjects; i++)
        {
            int topRoll = -1;
            int topMarks = -1;

            foreach (var entry in marks)
            {
                if (entry.Value.Count > i && entry.Value[i] > topMarks)
                {
                    topMarks = entry.Value[i];
                    topRoll = entry.Key;
                }
            }

            if (topRoll != -1)
                Console.WriteLine($"Subject {i + 1} Topper: Roll {topRoll} ({topMarks})");
        }
    }
}
}