using NuGet.Frameworks;
using AlgorithmPlayground;


namespace AlgorithmPlayGroundTests;

public class IsomorphicStringsTests
{
    [Fact]
    public void ShouldReturnFalseIfStringsAreNotIsomorphic()
    {
        //Arrange
        string string1 = "foo";
        string string2 = "bar";
        //Act 
        bool result = IsomorphicStrings.IsIsomorphic(string1, string2);
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void ShouldReturnTrueIfStringsAreIsomorphic()
    {
        // Arrange 
        string string1 = "dad";
        string string2 = "pap";
        // Act 
        bool result = IsomorphicStrings.IsIsomorphic(string1, string2);
        // Assert
        Assert.True(result);
    }

[Fact]
    public void ShouldReturnFalseIfTheStringsInTDoNotMatchS()
    {
        // Arrange 
        string string1 = "badc";
        string string2 = "baba";
        // Act 
        bool result = IsomorphicStrings.IsIsomorphic(string1, string2);
        // Assert
        Assert.False(result);
    }


[Fact]
    public void ShouldReturnFalseIfTheStringsInTDoNotMatch()
    {
        // Arrange 
        string string1 = "aaeaa";
        string string2 = "uuxyy";
        // Act 
        bool result = IsomorphicStrings.IsIsomorphic(string1, string2);
        // Assert
        Assert.False(result);
    }
}
