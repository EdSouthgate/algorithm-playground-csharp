using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using AlgorithmPlayground;

namespace AlgorithmPlaygroundTests
{
    public class SubsequenceTests
    {
        [Fact]
        public void ShouldReturnTrueIfSEqualsT()
        {
            // Arrange 
            string input1 = "a";
            string input2 = "a";
            // Act 
            Boolean result = Subsequence.IsSubsequence(input1, input2);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseIfSDoesNotEqualT()
        {
            // Arrange 
            string input1 = "a";
            string input2 = "b";
            // Act 
            Boolean result = Subsequence.IsSubsequence(input1, input2);
            // Assert 
            Assert.False(result);
        }


        [Fact]
        public void ShouldReturnTrueIfTIsASubSequenceOfS()
        {
            // Arrange 
            string input1 = "abc";
            string input2 = "aghblpc";
            // Act 
            Boolean result = Subsequence.IsSubsequence(input1, input2);
            // Assert 
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseIfSubstringIsOutOfOrder()
        {
            // Arrange 
            string string1 = "acb";
            string string2 = "ahbgdc";

            // Act
            Boolean result = Subsequence.IsSubsequence(string1, string2);

            // Assert 
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFalseIfThereAreNotEnoughLetters()
        {
            // Arrange 
            string string1 = "aaaaaa";
            string string2 = "bbaaaaa";

            // Act 
            Boolean result = Subsequence.IsSubsequence(string1, string2);

            // Assert 
            Assert.False(result);
        }
    }
}
