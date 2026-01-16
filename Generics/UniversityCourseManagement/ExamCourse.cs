using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
    // Represents exam-based evaluation
class ExamCourse : CourseType
{
    // Maximum marks for the exam
    public int MaxMarks { get; set; }

    // Exam evaluation logic
    public override void Evaluate()
    {
        Console.WriteLine($"Evaluated by Exam (Max Marks: {MaxMarks})");
    }
}
}