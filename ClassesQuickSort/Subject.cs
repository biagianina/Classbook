using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Subject
    {
        readonly string name;
        double[] grades = new double[0];

        public Subject(string subject)
        {
            this.name = subject;
        }

        public void AddGrade(double grade)
        {
            Array.Resize(ref grades, newSize: grades.Length + 1);
            grades[grades.Length - 1] = grade;
        }

        public double AverageSubjectGrade()
        {
            double averageGrade = 0;
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

        public bool IsSubject(string subject)
        {
            return subject == name;
        }
    }
}
