using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
    // Generic course class restricted to CourseType
class Course<T> where T : CourseType
{
    // Name of the course
    public string CourseName { get; set; }

    // Holds evaluation type (Exam / Assignment)
    public T CourseEvaluation { get; set; }

    // Displays course details and evaluation
    public void ShowCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}");
        CourseEvaluation.Evaluate();
    }
}
}