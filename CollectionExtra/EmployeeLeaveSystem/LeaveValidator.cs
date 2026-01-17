using System;
using System.Collections.Generic;

namespace EmployeeLeaveSystem
{
    // Handles leave validation logic
public class LeaveValidator
{
    // Validates a leave request
    public static bool ValidateLeave(
        int empId,
        Leave newLeave,
        Dictionary<int, List<Leave>> leaveRecords,
        HashSet<DateTime> holidays)
    {
        int leaveDays = 0;

        // Count valid leave days (exclude holidays)
        for (DateTime d = newLeave.StartDate; d <= newLeave.EndDate; d = d.AddDays(1))
        {
            if (!holidays.Contains(d.Date))
                leaveDays++;
        }

        // max 2 consecutive leaves
        if (leaveDays > 2)
            return false;

        // yearly casual leave limit (12)
        int yearlyLeaves = 0;
        if (leaveRecords.ContainsKey(empId))
        {
            foreach (var leave in leaveRecords[empId])
            {
                if (leave.StartDate.Year == newLeave.StartDate.Year)
                    yearlyLeaves++;
                
                // overlapping leave check
                if (!(newLeave.EndDate < leave.StartDate ||
                      newLeave.StartDate > leave.EndDate))
                    return false;
            }
        }
        return (yearlyLeaves + leaveDays) <= 12;
    }

    // Generates leave balance report
    public static void GenerateReport(
        Dictionary<int, List<Leave>> leaveRecords)
    {
        Console.WriteLine("\nLeave Balance Report:");
        foreach (var emp in leaveRecords)
        {
            Console.WriteLine($"Employee {emp.Key}: Used {emp.Value.Count} leaves");
        }
    }
}
}