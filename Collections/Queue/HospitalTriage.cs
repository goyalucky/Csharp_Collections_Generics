/* Hospital Triage System
Simulate a hospital triage system using a PriorityQueue where patients with higher severity are treated first.
Example:
Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
Order: Alice, John, Bob */


using System;
using System.Collections;
namespace Queue
{
public class HospitalTriage
{
    public static PriorityQueue<string,int> CreateQueue()
    {
        return new PriorityQueue<string, int>();
    }
}
}