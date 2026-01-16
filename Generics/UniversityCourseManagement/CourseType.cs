using System;
using System.Collections.Generic;

namespace UniversityCourseManagement
{
    abstract class CourseType
{
    // Stores evaluation method details
    public string EvaluationMethod { get; set; }

    // Forces child classes to implement evaluation logic
    public abstract void Evaluate();
}
}