using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        //attribute
        //Fact is a little piece of data attached to Test1
        //it goes looking for methods that has this Fact attribute
        [Fact]
        public void Test1()
        {
            // arrange section - put all your test data.
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.3);
            book.AddGrade(77.3);

            // act method - you produce the actual result
            var result = book.GetStatistics();

            // assert section - assert something about the value that was computed 
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.3, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

        }
    }
}
