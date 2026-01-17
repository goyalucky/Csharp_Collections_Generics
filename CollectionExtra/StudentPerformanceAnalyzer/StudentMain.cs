/* Student Performance Analyzer
Problem Statement
Create a C# program to analyze student performance. Each student appears for multiple subjects.
Store:
    ● Student details in a List<Student>
    ● Marks in a Dictionary<int, List<int>> (RollNo → Marks)
Tasks
1. Calculate average marks for each student.
2. A student passes if:
    ○ Average ≥ 40
    ○ No subject mark < 30
3. Display:
    ○ Students who passed overall but failed in at least one subject
    ○ Top scorer of each subject
4. Remove students who failed 3 consecutive exams.

Edge Cases
● Student with no marks recorded
● Marks exactly 30 or 40
● Subjects count differs per student
● Removing items while iterating a collection
● Duplicate roll numbers */

using System;
using System.Collections.Generic;

namespace StudentPerformanceAnalyzer
{
public class StudentMain
{
    public static void Start()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "lucky"),
            new Student(2, "Abhay"),
            new Student(3, "Rishabh"),
            new Student(4, "Shreyash")
        };

        Dictionary<int, List<int>> marks = new Dictionary<int, List<int>>
        {
            {1, new List<int>{45, 50, 60}},
            {2, new List<int>{40, 30, 20}},   // fails one subject
            {3, new List<int>{25, 20, 10}},   // fails badly
            {4, new List<int>()}              // no marks
        };

        Console.WriteLine("Student Results:\n");

        List<int> toRemove = new List<int>();
        Dictionary<int, int> failCount = new Dictionary<int, int>();

        foreach (var s in students)
        {
            if (!marks.ContainsKey(s.RollNo) || marks[s.RollNo].Count == 0)
            {
                Console.WriteLine($"{s.Name}: No marks recorded");
                continue;
            }

            var m = marks[s.RollNo];
            double avg = PerformanceAnalyzer.GetAverage(m);
            bool passed = PerformanceAnalyzer.HasPassed(m);
            bool subjectFail = m.Exists(x => x < 30);

            Console.WriteLine($"{s.Name} → Avg: {avg}");

            if (avg >= 40 && subjectFail)
                Console.WriteLine("⚠ Passed overall but failed in a subject");

            if (!passed)
            {
                if (!failCount.ContainsKey(s.RollNo))
                    failCount[s.RollNo] = 1;
                else
                    failCount[s.RollNo]++;

                if (failCount[s.RollNo] >= 3)
                    toRemove.Add(s.RollNo);
            }
        }

        Console.WriteLine("\nTop Scorers:");
        PerformanceAnalyzer.DisplayTopScorers(marks);

        // Safe removal
        students.RemoveAll(s => toRemove.Contains(s.RollNo));
        foreach (var r in toRemove)
            marks.Remove(r);

        Console.WriteLine("\nRemaining Students:");
        foreach (var s in students)
            Console.WriteLine($"{s.RollNo} - {s.Name}");
    }
}
}