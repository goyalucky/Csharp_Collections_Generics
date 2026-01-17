/* Employee Leave Validation System
Problem Statement - Design a leave management system.
Use:
● Dictionary<int, List<Leave>>
● HashSet<DateTime> for holidays
Tasks
1. Validate leave request based on:
    ○ Max 2 consecutive leaves
    ○ Holidays should not count as leave
    ○ Max 12 casual leaves per year
2. Reject overlapping leave requests.
3. Generate leave balance report.

Edge Cases
● Leave spanning weekends & holidays
● Year-end leave (Dec → Jan)
● Back-to-back leave requests
● Duplicate leave dates
● Leap year dates */

using System;
using System.Collections.Generic;

namespace EmployeeLeaveSystem
{
    public class LeaveMain
{
    public static void Start()
    {
        Dictionary<int, List<Leave>> leaveRecords =
            new Dictionary<int, List<Leave>>();

        HashSet<DateTime> holidays = new HashSet<DateTime>
        {
            new DateTime(2024, 12, 25),
            new DateTime(2024, 1, 1)
        };

        int empId = 101;
        Leave leave1 = new Leave(
            new DateTime(2024, 12, 24),
            new DateTime(2024, 12, 26)); // includes holiday

        bool approved = LeaveValidator.ValidateLeave(
            empId, leave1, leaveRecords, holidays);

        if (approved)
        {
            if (!leaveRecords.ContainsKey(empId))
                leaveRecords[empId] = new List<Leave>();

            leaveRecords[empId].Add(leave1);
            Console.WriteLine("Leave Approved");
        }
        else
        {
            Console.WriteLine("Leave Rejected");
        }
        LeaveValidator.GenerateReport(leaveRecords);
    }
}
}