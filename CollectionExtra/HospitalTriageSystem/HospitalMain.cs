/* Hospital Emergency Triage System
Problem Statement - Manage patient prioritization in emergency ward.
Use:
● PriorityQueue<Patient, int>
● Dictionary<int, Patient>

Tasks
1. Assign priority based on:
    ○ Severity
    ○ Age (senior citizens)
    ○ Arrival time
2. Update severity dynamically.
3. Track waiting time.

Edge Cases
● Same priority values
● Priority update after enqueue
● Patient removed unexpectedly
● Starvation of low-priority patients
● Queue empty scenario */

using System;

namespace HospitalTriageSystem
{
    public class HospitalMain
    {
        public static void Start()
        {
            TriageService triage = new TriageService();
            // Add patients
            triage.EnqueuePatient(new Patient(1, "Amit", 6, 30));
            triage.EnqueuePatient(new Patient(2, "Ravi", 8, 65));
            triage.EnqueuePatient(new Patient(3, "Neha", 6, 65));

            // Update severity dynamically
            triage.UpdateSeverity(1, 9);

            // Treat patients
            Patient p;
            while ((p = triage.DequeuePatient()) != null)
            {
                Console.WriteLine(
                    $"Treating {p.Name}, Waited: {triage.GetWaitingTime(p):F2} mins");
            }

            // Queue empty case
            if (triage.DequeuePatient() == null)
                Console.WriteLine("No patients waiting");
        }
    }
}
