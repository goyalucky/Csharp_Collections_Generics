using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
    // Represents assignment-based evaluation
class AssignmentCourse : CourseType
{
    // Total number of assignments
    public int TotalAssignments { get; set; }

    // Assignment evaluation logic
    public override void Evaluate()
    {
        Console.WriteLine($"Evaluated by {TotalAssignments} Assignments");
    }
}
}