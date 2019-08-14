using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Subject
    {
        public string name;
        public double[] grades = new double[0];
        double averageGrade;
        public Subject(string subject)
        {
            this.name = subject;
            
        }

        public double AverageSubjectGrade()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                averageGrade += grades[i];
            }
            return averageGrade / grades.Length;
            
        }

        public double BiggestGrade()
        {
            double biggestGrade = 0;
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
