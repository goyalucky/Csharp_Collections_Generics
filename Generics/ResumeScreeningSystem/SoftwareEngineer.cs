using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    // Software Engineer job role
public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer()
    {
        RoleName = "Software Engineer";
    }

    // Screening logic for software engineer
    public override void Screen()
    {
        Console.WriteLine("Screening for Software Engineer: DSA, OOPs, Coding");
    }
}
}