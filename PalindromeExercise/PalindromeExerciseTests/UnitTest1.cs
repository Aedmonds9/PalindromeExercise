using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("hannah", true)]
        static void Mytest(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);
            
            Assert.Equal(expected, actual);

        }

    }    
}







