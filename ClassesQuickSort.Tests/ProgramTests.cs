using System;
using Xunit;

namespace ClassesQuickSort.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void SingleGradeAverageSubjectGrade()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            var currentSubject = student.FindSubject("Biology");
            Assert.Equal(9, currentSubject.AverageSubjectGrade());
        }

        [Fact]
        public void MultipleGradesAverageGrade()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            student.ReceiveGrade("Biology", 7);
            var currentSubject = student.FindSubject("Biology");
            Assert.Equal(8, currentSubject.AverageSubjectGrade());
        }

        [Fact]
        public void MultipleSubjectsAverageGrade()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            student.ReceiveGrade("Chemistry", 7);
            var currentSubject = student.FindSubject("Biology");
            Assert.Equal(9, currentSubject.AverageSubjectGrade());
        }

        [Fact]
        public void MultipleSubjectsAverageGradeOfOne()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            student.ReceiveGrade("Chemistry", 7);
            var currentSubject = student.FindSubject("Chemistry");
            Assert.Equal(7, currentSubject.AverageSubjectGrade());
        }

        [Fact]
        public void MultipleSubjectsAverageGradeOfOneWithTwoGrades()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            student.ReceiveGrade("Chemistry", 7);
            student.ReceiveGrade("Chemistry", 8);
            var currentSubject = student.FindSubject("Chemistry");
            Assert.Equal(7.5, currentSubject.AverageSubjectGrade());
        }

        [Fact]
        public void BiggestGreadForOneSubject()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Biology", 9);
            student.ReceiveGrade("Chemistry", 7);
            student.ReceiveGrade("Chemistry", 8);
            var currentSubject = student.FindSubject("Chemistry");
            Assert.Equal(8, currentSubject.BiggestGrade());
        }

        [Fact]
        public void AverageGradeForStudent()
        {
            Student student = new Student("John");
            student.ReceiveGrade("Chemistry", 5);
            student.ReceiveGrade("Chemistry", 5);
            student.ReceiveGrade("Chemistry", 5);
            student.ReceiveGrade("Biology", 10);
            student.ReceiveGrade("Biology", 10);
            student.ReceiveGrade("Maths", 10);
            student.ReceiveGrade("English", 10);
            student.ReceiveGrade("English", 10);
            student.ReceiveGrade("Sports", 5);
            Assert.Equal(8, student.AverageGrade());
        }

        [Fact]
        public void ClassbookOfFourRankingWithGrade()
        {
            Classbook classbook = new Classbook();
            classbook.AddStudent(new Student("John"));
            classbook.AddStudent(new Student("Marry"));
            classbook.AddStudent(new Student("Linda"));
            classbook.AddStudent(new Student("Mike"));
            var john = classbook.FindStudent("John");
            var marry = classbook.FindStudent("Marry");
            var linda = classbook.FindStudent("Linda");
            var mike = classbook.FindStudent("Mike");
            john.ReceiveGrade("Biology", 6);
            john.ReceiveGrade("Biology", 8);
            john.ReceiveGrade("Chemistry", 8);
            marry.ReceiveGrade("Maths", 10);
            marry.ReceiveGrade("Biology", 8);
            marry.ReceiveGrade("Chemistry", 8);
            linda.ReceiveGrade("Maths", 7);
            linda.ReceiveGrade("Biology", 5);
            mike.ReceiveGrade("Chemistry", 10);
            Assert.Equal(1, classbook.Rank("Mike"));
            Assert.Equal(2, classbook.Rank("Marry"));
            Assert.Equal(3, classbook.Rank("John"));
            Assert.Equal(4, classbook.Rank("Linda"));
        }

        [Fact]
        public void AverageGradeForAStudentInClassbook()
        {
            Classbook classbook = new Classbook();
            classbook.AddStudent(new Student("John"));
            classbook.AddStudent(new Student("Marry"));
            classbook.AddStudent(new Student("Linda"));
            classbook.AddStudent(new Student("Mike"));
            var john = classbook.FindStudent("John");
            var marry = classbook.FindStudent("Marry");
            var linda = classbook.FindStudent("Linda");
            var mike = classbook.FindStudent("Mike");
            john.ReceiveGrade("Biology", 6);
            john.ReceiveGrade("Biology", 8);
            john.ReceiveGrade("Chemistry", 8);
            marry.ReceiveGrade("Maths", 10);
            marry.ReceiveGrade("Biology", 8);
            marry.ReceiveGrade("Chemistry", 8);
            linda.ReceiveGrade("Maths", 7);
            linda.ReceiveGrade("Biology", 5);
            mike.ReceiveGrade("Chemistry", 10);
            Assert.Equal(7.5, john.AverageGrade());
        }

        [Fact]
        public void AverageSubjectGradeForAStudentInClassbook()
        {
            Classbook classbook = new Classbook();
            classbook.AddStudent(new Student("John"));
            classbook.AddStudent(new Student("Marry"));
            classbook.AddStudent(new Student("Linda"));
            classbook.AddStudent(new Student("Mike"));
            var john = classbook.FindStudent("John");
            var marry = classbook.FindStudent("Marry");
            var linda = classbook.FindStudent("Linda");
            var mike = classbook.FindStudent("Mike");
            john.ReceiveGrade("Biology", 6);
            john.ReceiveGrade("Biology", 8);
            john.ReceiveGrade("Chemistry", 8);
            marry.ReceiveGrade("Maths", 10);
            marry.ReceiveGrade("Biology", 8);
            marry.ReceiveGrade("Chemistry", 8);
            linda.ReceiveGrade("Maths", 7);
            linda.ReceiveGrade("Biology", 5);
            mike.ReceiveGrade("Chemistry", 10);
            var biology = john.FindSubject("Biology");
            Assert.Equal(7, biology.AverageSubjectGrade());
        }
    }
}
