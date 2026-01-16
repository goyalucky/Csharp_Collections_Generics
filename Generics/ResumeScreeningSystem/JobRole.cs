using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    // Base class for all job roles
public abstract class JobRole
{
    // Job role name
    public string RoleName { get; set; }

    // Each role defines its own screening logic
    public abstract void Screen();
}
}