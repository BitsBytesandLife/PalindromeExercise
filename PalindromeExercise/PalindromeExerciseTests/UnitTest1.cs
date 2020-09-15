using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("noon", true)]
        [InlineData("car", false)]
        public void Test(string word,bool expected)
        {
            //arrange
            var wordSmith = new WordSmith();
            //act
            var actual = wordSmith.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
