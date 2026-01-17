using System;
using System.Collections.Generic;

namespace ExamNormalizationSystem
{
    // Holds student marks and total
    public class StudentResult
    {
        public int RollNo;
        public List<int> Marks;
        public int Total;

        public StudentResult(int rollNo, List<int> marks)
        {
            RollNo = rollNo;
            Marks = marks;
            Total = 0;
        }

        // Calculate total safely
        public void CalculateTotal(int maxMarks)
        {
            Total = 0;
            foreach (int m in Marks)
            {
                // Prevent exceeding maximum
                Total += Math.Min(m, maxMarks);
            }
        }
    }
}
