using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Student
    {
        readonly string name;
        double grade;
        Subject[] subjectGrades = new Subject[0];


        public Student(string name)
        {
            this.name = name;
        }

        public void Grade(string subject, double grade)
        {
            bool exist = false;
            if (grade > 0 && grade <= 10)
            {
                if (subjectGrades.Length == 0)
                {
                    Array.Resize(ref subjectGrades, subjectGrades.Length + 1);
                    subjectGrades[subjectGrades.Length - 1] = new Subject(subject);
                    Array.Resize(ref subjectGrades[subjectGrades.Length - 1].grades, subjectGrades[subjectGrades.Length - 1].grades.Length + 1);
                    subjectGrades[subjectGrades.Length - 1].grades[subjectGrades[subjectGrades.Length - 1].grades.Length - 1] = grade;
                }
                else
                {
                    for (int i = 0; i < subjectGrades.Length; i++)
                    {
                        if (subjectGrades[i].name == subject)
                        {
                            Array.Resize(ref subjectGrades[subjectGrades.Length - 1].grades, subjectGrades[subjectGrades.Length - 1].grades.Length + 1);
                            subjectGrades[subjectGrades.Length - 1].grades[subjectGrades[subjectGrades.Length - 1].grades.Length - 1] = grade;
                            exist = true;
                            break;
                        }
 
                    }

                    if (!exist)
                    {
                        Array.Resize(ref subjectGrades, subjectGrades.Length + 1);
                        subjectGrades[subjectGrades.Length - 1] = new Subject(subject);
                        Array.Resize(ref subjectGrades[subjectGrades.Length - 1].grades, subjectGrades[subjectGrades.Length - 1].grades.Length + 1);
                        subjectGrades[subjectGrades.Length - 1].grades[subjectGrades[subjectGrades.Length - 1].grades.Length - 1] = grade;
                    }
                }
  
            }
        }

        public double BiggestSubjectGrade(string subject)
        {
            for (int i = 0; i < subjectGrades.Length; i++)
            {
                if (subjectGrades[i].name == subject)
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
                if (subjectGrades[i].name == subject)
                {
                    return subjectGrades[i].AverageSubjectGrade();
                }

            }
            return 0;
        }
    }
}
