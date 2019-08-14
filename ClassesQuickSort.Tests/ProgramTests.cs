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
            Assert.Equal(9, student.AverageGrade("Biology"));
        }

        [Fact]
        public void MultipleGradesAverageGrade()
        {
            Student student = new Student("John");
            student.Grade("Biology", 9);
            student.Grade("Biology", 7);
            Assert.Equal(8, student.AverageGrade("Biology"));
        }

    }
}
