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
            Assert.Equal(7.5d, student.AverageSubjectGrade("Chemistry"));
        }

        [Fact]
        public void BiggestGreadForOneSubject()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Chemistry", 7);
            student.Grade("Chemistry", 8);
            Assert.Equal(8, student.BiggestSubjectGrade("Chemistry"));
        }

        [Fact]
        public void AverageGradeForStudent()
        {
            Student student = new Student("John");
            student.Grade("Chemistry", 5);
            student.Grade("Chemistry", 5);
            student.Grade("Chemistry", 5);
            student.Grade("Biology", 10);
            student.Grade("Biology", 10);
            student.Grade("Maths", 10);
            student.Grade("English", 10);
            student.Grade("English", 10);
            student.Grade("Sports", 5);
            Assert.Equal(8, student.AverageGrade());
        }

        [Fact]
        public void ClassbookOfFourAverageGradeOfStudent()
        {
            Classbook classbook = new Classbook(4);
            classbook.CreateStudent("John");
            classbook.CreateStudent("Marry");
            classbook.CreateStudent("Linda");
            classbook.CreateStudent("Mike");
            classbook.GiveGrade("John", "Biology", 6);
            classbook.GiveGrade("John", "Biology", 8);
            classbook.GiveGrade("John", "Chemistry", 8);
            classbook.GiveGrade("Marry", "Maths", 10);
            classbook.GiveGrade("Marry", "Biology", 8);
            classbook.GiveGrade("Marry", "Chemistry", 8);
            classbook.GiveGrade("Linda", "Maths", 7);
            classbook.GiveGrade("Linda", "Biology", 5);
            classbook.GiveGrade("Mike", "Chemistry", 10);
            Assert.Equal(6, classbook.StudentAverageGrade("Linda"));
        }
    }
}
