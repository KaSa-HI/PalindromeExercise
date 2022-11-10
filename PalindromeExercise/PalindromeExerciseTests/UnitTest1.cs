using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("kahvi", false)]
        [InlineData("kayak", true)]
        [InlineData("level", true)]
        [InlineData("redivider", true)]
        [InlineData("elephant", false)]
        public void Test1(string unit, bool expected)
        {
            //Arrange (make obj testing)
            WordSmith unitTestMethods = new WordSmith();

            //Act (
            bool result = unitTestMethods.IsAPalindrome(unit);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
