using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    // Generic resume class restricted to JobRole
public class Resume<T> where T : JobRole
{
    // Process a single resume
    public void ProcessResume(T role)
    {
        Console.WriteLine($"Processing resume for: {role.RoleName}");
        role.Screen();
    }

    // Generic method to process multiple resumes
    public static void ProcessBatch<U>(List<U> roles)
        where U : JobRole
    {
        foreach (var role in roles)
        {
            Console.WriteLine($"Batch Processing: {role.RoleName}");
            role.Screen();
            Console.WriteLine();
        }
    }
}
}