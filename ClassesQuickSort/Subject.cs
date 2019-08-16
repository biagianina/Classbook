using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Subject
    {
        double[] grades = new double[0];
        double averageGrade;

        public Subject(string subject)
        {
            Name = subject;
        }

        public string Name { get; set; }

        public double[] AddGrade(double grade)
        {
            Array.Resize(ref grades, newSize: grades.Length + 1);
            grades[grades.Length - 1] = grade;
            return grades;
        }

        public double AverageSubjectGrade()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                averageGrade += grades[i];
            }

            return averageGrade / grades.Length;
        }

        public double BiggestGradeOfSubject()
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
