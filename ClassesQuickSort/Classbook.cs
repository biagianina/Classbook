using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Classbook
    {
        Student[] students = new Student[0];

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public int Rank(string name)
        {
            Student[] rankedStudents = QuickSort(students, 0, students.Length - 1);
            for (int i = 0; i < rankedStudents.Length; i++)
            {
                if (rankedStudents[i].IsStudent(name))
                {
                    return i + 1;
                }
            }

            return 0;
        }

        public Student FindStudent(string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].IsStudent(name))
                {
                    return students[i];
                }
            }

            return null;
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
