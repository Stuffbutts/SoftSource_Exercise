using System.Text.RegularExpressions;
using SoftSource_Exercise;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void GeneratesTheExpectedNumberOfCharacters()
    {
        var result = TriangleGenerator.GenerateTriangle(10);
        var lastLine = result[^1];

        var r = Regex.Matches(lastLine, "\\*");

        Assert.Equal(10, r.Count);
    }
}