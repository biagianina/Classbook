﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Classbook
    {
        public Student[] Students = new Student[0];

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public string[] Rank()
        {
            string[] rank = new string[Students.Length];
            Student[] rankedStudents = QuickSort(Students, 0, Students.Length - 1);
            for (int i = 0; i < rankedStudents.Length; i++)
            {
                rank[i] = rankedStudents[i].Name + " : " + Convert.ToString(Students[i].AverageGrade());
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
