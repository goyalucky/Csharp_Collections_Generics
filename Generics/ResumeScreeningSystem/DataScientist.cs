using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    // Data Scientist job role
public class DataScientist : JobRole
{
    public DataScientist()
    {
        RoleName = "Data Scientist";
    }

    // Screening logic for data scientist
    public override void Screen()
    {
        Console.WriteLine("Screening for Data Scientist: ML, Statistics, Python");
    }
}
}