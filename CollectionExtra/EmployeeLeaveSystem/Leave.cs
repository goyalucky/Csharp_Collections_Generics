using System;

namespace EmployeeLeaveSystem
{
    // Represents a leave request
public class Leave
{
    public DateTime StartDate;
    public DateTime EndDate;

    public Leave(DateTime start, DateTime end)
    {
        StartDate = start;
        EndDate = end;
    }
}
}