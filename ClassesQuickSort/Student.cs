using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesQuickSort
{
    public class Student
    {
        readonly string name;
        string subject;
        double grade;
        double subjectAverageGrade;
        int subjectNumberOfGrades;

        public Student(string name)
        {
            this.name = name;
        }

        public void Grade(string subject, double grade)
        {
            this.grade = grade;
            this.subject = subject;
            this.subjectNumberOfGrades++;
            this.subjectAverageGrade += grade;
        }

        public double AverageGrade(string subject)
        {
            return subjectAverageGrade / subjectNumberOfGrades;
        }
    }
}
