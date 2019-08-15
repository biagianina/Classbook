using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Student
    {
        Subject[] subjectGrades = new Subject[0];

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public void Grade(string subject, double grade)
            {
            bool exist = false;
            const int biggestGrade = 10;
            if (grade <= 0 || grade > biggestGrade)
            {
                return;
            }

            if (subjectGrades.Length == 0)
            {
                Array.Resize(ref subjectGrades, subjectGrades.Length + 1);
                subjectGrades[subjectGrades.Length - 1] = new Subject(subject);
                subjectGrades[subjectGrades.Length - 1].AddGrade(grade);
            }
            else
            {
                for (int i = 0; i < subjectGrades.Length; i++)
                {
                    if (subjectGrades[i].Name == subject)
                    {
                        subjectGrades[subjectGrades.Length - 1].AddGrade(grade);
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    Array.Resize(ref subjectGrades, subjectGrades.Length + 1);
                    subjectGrades[subjectGrades.Length - 1] = new Subject(subject);
                    subjectGrades[subjectGrades.Length - 1].AddGrade(grade);
                }
            }
        }

        public double BiggestSubjectGrade(string subject)
        {
            for (int i = 0; i < subjectGrades.Length; i++)
            {
                if (subjectGrades[i].Name == subject)
                {
                    return subjectGrades[i].BiggestGrade();
                }
            }

            return 0;
        }

        public double AverageGrade()
        {
            double result = 0;
            for (int i = 0; i < subjectGrades.Length; i++)
            {
                result += subjectGrades[i].AverageSubjectGrade();
            }

            return result / subjectGrades.Length;
        }

        public double AverageSubjectGrade(string subject)
        {
            for (int i = 0; i < subjectGrades.Length; i++)
            {
                if (subjectGrades[i].Name == subject)
                {
                    return subjectGrades[i].AverageSubjectGrade();
                }
            }

            return 0;
        }
    }
}
