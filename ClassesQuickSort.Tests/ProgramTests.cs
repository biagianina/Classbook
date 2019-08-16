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
        public void ClassbookOfFourRankingWithGrade()
        {
            Classbook classbook = new Classbook();
            classbook.AddStudent("John");
            classbook.AddStudent("Marry");
            classbook.AddStudent("Linda");
            classbook.AddStudent("Mike");
            classbook.Students[0].Grade("Biology", 6);
            classbook.Students[0].Grade("Biology", 8);
            classbook.Students[0].Grade("Chemistry", 8);
            classbook.Students[1].Grade("Maths", 10);
            classbook.Students[1].Grade("Biology", 8);
            classbook.Students[1].Grade("Chemistry", 8);
            classbook.Students[2].Grade("Maths", 7);
            classbook.Students[2].Grade("Biology", 5);
            classbook.Students[3].Grade("Chemistry", 10);
            Assert.Equal("Mike : 10", classbook.Rank()[0]);
            Assert.Equal("Marry : 8.66666666666667", classbook.Rank()[1]);
            Assert.Equal("John : 7.5", classbook.Rank()[2]);
            Assert.Equal("Linda : 6", classbook.Rank()[3]);
        }
    }
}
