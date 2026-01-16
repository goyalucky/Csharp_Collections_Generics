/* AI-Driven Resume Screening System
o Concepts: Generic Classes, Generic Methods, Constraints
o Problem Statement: Develop a resume screening system that can process resumes for different job roles while ensuring type safety.
o Hints:
▪ Create an abstract class JobRole (SoftwareEngineer, DataScientist).
▪ Implement a generic class Resume<T> where T : JobRole to process resumes dynamically.
▪ Use List<T> to handle multiple job roles in the screening pipeline. */


using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
   public class ResumeScreeningMain
{
    public static void Start()
    {
        // Individual resume processing
        Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>();
        seResume.ProcessResume(new SoftwareEngineer());

        Console.WriteLine();

        // Batch resume screening using List<T>
        List<JobRole> jobRoles = new List<JobRole>
        {
            new SoftwareEngineer(),
            new DataScientist()
        };

        // Process multiple roles dynamically
        Resume<JobRole>.ProcessBatch(jobRoles);
    }
}
}