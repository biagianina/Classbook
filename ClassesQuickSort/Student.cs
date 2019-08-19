using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Student
    {
        readonly string name;
        Subject[] subjects = new Subject[0];

        public Student(string name)
        {
            this.name = name;
        }

        public void ReceiveGrade(string subject, double grade)
        {
            const int biggestGrade = 10;
            if (grade <= 0 || grade > biggestGrade)
            {
                return;
            }

            if (subjects.Length == 0)
            {
                CreateSubject(subject, grade);
            }
            else
            {
                if (SubjectExists(subject) != null)
                {
                    subjects[subjects.Length - 1].AddGrade(grade);
                }
                else
                {
                    CreateSubject(subject, grade);
                }
            }
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

        public Subject SubjectExists(string subject)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i].IsSubject(subject))
                {
                    return subjects[i];
                }
            }

            return null;
        }

        public bool IsStudent(string student)
        {
            return name == student;
        }

        private void CreateSubject(string subject, double grade)
        {
            Array.Resize(ref subjects, subjects.Length + 1);
            subjects[subjects.Length - 1] = new Subject(subject);
            subjects[subjects.Length - 1].AddGrade(grade);
        }
    }
}
