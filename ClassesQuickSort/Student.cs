using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Student
    {
        public string Name;
        Subject[] subjects = new Subject[0];

        public Student(string name)
        {
            this.Name = name;
        }

        public void Grade(string subject, double grade)
        {
            bool exist = false;
            const int biggestGrade = 10;
            if (grade <= 0 || grade > biggestGrade)
            {
                return;
            }

            if (subjects.Length == 0)
            {
                Array.Resize(ref subjects, subjects.Length + 1);
                subjects[subjects.Length - 1] = new Subject(subject);
                subjects[subjects.Length - 1].AddGrade(grade);
            }
            else
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    if (subjects[i].Name == subject)
                    {
                        subjects[subjects.Length - 1].AddGrade(grade);
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    Array.Resize(ref subjects, subjects.Length + 1);
                    subjects[subjects.Length - 1] = new Subject(subject);
                    subjects[subjects.Length - 1].AddGrade(grade);
                }
            }
        }

        public double BiggestSubjectGrade(string subject)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i].Name == subject)
                {
                    return subjects[i].BiggestGradeOfSubject();
                }
            }

            return 0;
        }

        public double AverageGrade()
        {
            double result = 0;
            for (int i = 0; i < subjects.Length; i++)
            {
                result += subjects[i].AverageSubjectGrade();
            }

            return result / subjects.Length;
        }

        public double AverageSubjectGrade(string subject)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i].Name == subject)
                {
                    return subjects[i].AverageSubjectGrade();
                }
            }

            return 0;
        }
    }
}
