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
    }
}
