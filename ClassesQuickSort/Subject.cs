using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Subject
    {
        public string name;
        public decimal[] grades = new decimal[0];
        decimal averageGrade;
        public Subject(string subject)
        {
            this.name = subject;
            
        }

        public decimal AverageSubjectGrade()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                averageGrade += grades[i];
            }
            return averageGrade / grades.Length;
            
        }

        public decimal BiggestGrade()
        {
            decimal biggestGrade = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (biggestGrade < grades[i])
                {
                    biggestGrade = grades[i];
                }
            }

            return biggestGrade;
        }
    }
}
