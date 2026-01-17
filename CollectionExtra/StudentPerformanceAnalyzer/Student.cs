using System;
using System.Collections.Generic;

namespace StudentPerformanceAnalyzer
{
    // Represents a student entity
public class Student
{
    public int RollNo;
    public string Name;

    public Student(int rollNo, string name)
    {
        RollNo = rollNo;
        Name = name;
    }
}
}