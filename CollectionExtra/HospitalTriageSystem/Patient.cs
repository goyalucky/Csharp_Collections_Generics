using System;

namespace HospitalTriageSystem
{
    // Represents a patient in emergency ward
    public class Patient
    {
        public int Id;
        public string Name;
        public int Severity;       
        public int Age;
        public DateTime ArrivalTime;

        public Patient(int id, string name, int severity, int age)
        {
            Id = id;
            Name = name;
            Severity = severity;
            Age = age;
            ArrivalTime = DateTime.Now;
        }
    }
}
