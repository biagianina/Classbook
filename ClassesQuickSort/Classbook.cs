using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Classbook
    {
        readonly Student[] students = new Student[0];

        public Classbook(int numberOfStudents)
        {
            Array.Resize(ref students, students.Length + numberOfStudents);
        }

        public void CreateStudent(string name)
        {
           for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = new Student(name);
                    break;
                }
            }
        }

        public void GiveGrade(string name, string subject, double grade)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == name)
                {
                    students[i].Grade(subject, grade);
                }
            }
        }

        public double StudentAverageGrade(string student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == student)
                {
                    return students[i].AverageGrade();
                }
            }

            return 0;
        }

        public double StudentSubjectAverageGrade(string student, string subject)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == student)
                {
                    return students[i].AverageSubjectGrade(subject);
                }
            }

            return 0;
        }

        public double StudentSubjectBiggestGrade(string student, string subject)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == student)
                {
                    return students[i].BiggestSubjectGrade(subject);
                }
            }

            return 0;
        }
    }
}
