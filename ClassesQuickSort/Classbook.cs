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

        public void CreateStudents(string name)
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

        public string[] Rank()
        {
            string[] rank = new string[students.Length];
            Student[] rankedStudents = QuickSort(students, 0, students.Length - 1);
            for (int i = 0; i < rankedStudents.Length; i++)
            {
                rank[i] = rankedStudents[i].Name + " : " + Convert.ToString(students[i].AverageGrade());
            }

            return rank;
        }

        static Student[] QuickSort(Student[] students, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = students[(i + j) / 2].AverageGrade();

            if (i <= j)
            {
                while (students[i].AverageGrade() > pivot)
                {
                    i++;
                }

                while (pivot > students[j].AverageGrade())
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = students[j];
                    students[j] = students[i];
                    students[i] = temp;

                    i++;
                    j--;
                }

                if (left < j)
                {
                    QuickSort(students, left, j);
                }

                if (i < right)
                {
                    QuickSort(students, i, right);
                }
            }

            return students;
        }
    }
}
