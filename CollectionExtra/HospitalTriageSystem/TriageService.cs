using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace HospitalTriageSystem
{
    // Handles patient prioritization logic
    public class TriageService
    {
        private PriorityQueue<Patient, int> queue = new PriorityQueue<Patient, int>();

        private Dictionary<int, Patient> patients = new Dictionary<int, Patient>();

        // Calculate priority score
        private int CalculatePriority(Patient p)
        {
            int priority = p.Severity * 10;

            // Senior citizens get higher priority
            if (p.Age >= 60)
                priority += 20;

            // Earlier arrival gets slight boost
            priority += (int)(DateTime.Now - p.ArrivalTime).TotalMinutes;

            // Higher value → higher priority, so use negative
            return -priority;
        }

        // Add new patient
        public void EnqueuePatient(Patient p)
        {
            patients[p.Id] = p;
            queue.Enqueue(p, CalculatePriority(p));
        }

        // Treat next patient
        public Patient DequeuePatient()
        {
            if (queue.Count == 0)
                return null;

            Patient p = queue.Dequeue();
            patients.Remove(p.Id);
            return p;
        }

        // Update patient severity dynamically
        public void UpdateSeverity(int patientId, int newSeverity)
        {
            if (!patients.ContainsKey(patientId))
                return;

            Patient p = patients[patientId];
            p.Severity = newSeverity;

            // Rebuild queue since PriorityQueue doesn't support update
            RebuildQueue();
        }

        // Calculate waiting time in minutes
        public double GetWaitingTime(Patient p)
        {
            return (DateTime.Now - p.ArrivalTime).TotalMinutes;
        }

        // Rebuild queue to avoid starvation & priority issues
        private void RebuildQueue()
        {
            queue = new PriorityQueue<Patient, int>();

            foreach (var p in patients.Values)
                queue.Enqueue(p, CalculatePriority(p));
        }
    }
}



  