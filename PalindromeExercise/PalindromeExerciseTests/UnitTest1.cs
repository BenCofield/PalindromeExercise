using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("notRaceCar", false)]
        [InlineData("asdffdsa", true)]
        [InlineData("repaper", true)]
        [InlineData("randstring", false)]
        public void IsAPalindrome_Test(string str, bool expected)
        {
            var w = new WordSmith();

            var actual = w.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
