using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
 public class UniversityCourseMain
{
    public static void Start()
    {
        // List can store any course type dynamically
        List<Course<CourseType>> courses = new List<Course<CourseType>>();

        // Adding exam-based course
        
        courses.Add(new Course<CourseType>
        {
            CourseName = "Data Structures",
            CourseEvaluation = new ExamCourse { MaxMarks = 100 }
        });

        // Adding assignment-based course
        courses.Add(new Course<CourseType>
        {
            CourseName = "Web Development",
            CourseEvaluation = new AssignmentCourse { TotalAssignments = 6 }
        });

        // Display all course details
        foreach (var course in courses)
        {
            course.ShowCourseDetails();
            Console.WriteLine();
        }
    }
}
}