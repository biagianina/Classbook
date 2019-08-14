using System;
using Xunit;

namespace ClassesQuickSort.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void SingleGradeAverageGrade()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            Assert.Equal(9, student.AverageSubjectGrade("Biology"));
        }

        [Fact]
        public void MultipleGradesAverageGrade()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Biology", 7);
            Assert.Equal(8, student.AverageSubjectGrade("Biology"));
        }

        [Fact]
        public void MultipleSubjectsAverageGrade()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Chemistry", 7);
            Assert.Equal(9, student.AverageSubjectGrade("Biology"));
        }

        [Fact]
        public void MultipleSubjectsAverageGradeOfOne()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Chemistry", 7);
            Assert.Equal(7, student.AverageSubjectGrade("Chemistry"));
        }

        [Fact]
        public void MultipleSubjectsAverageGradeOfOneWithTwoGrades()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Chemistry", 7);
            student.Grade("Chemistry", 8);
            Assert.Equal(7, student.AverageSubjectGrade("Chemistry"));
        }

        [Fact]
        public void BiggestGreadForOneSubject()
        {
            Student student = new Student("John");
            student.Grade("Chemistry", 9);
            student.Grade("Chemistry", 7);
            student.Grade("Chemistry", 8);
            Assert.Equal(9, student.BiggestSubjectGrade("Chemistry"));
        }

        [Fact]
        public void AverageGradeForStudent()
        {
            Student student = new Student("John");
            student.Grade("Chemistry", 9);
            student.Grade("Chemistry", 7);
            student.Grade("Chemistry", 8);
            student.Grade("Biology", 9);
            student.Grade("Biology", 7);
            student.Grade("Maths", 9);
            student.Grade("Maths", 10);
            student.Grade("Enligsh", 9);
            student.Grade("English", 7);
            Assert.Equal(8, student.AverageGrade());
        }



    }
}
