using ConsoleApp1.Dictionary;

namespace ConsoleApp1.Test;

using Xunit;

public class ReplaceCharacterTests
{
    private readonly ReplaceCharacter _replaceCharacter;

    public ReplaceCharacterTests()
    {
        _replaceCharacter = new ReplaceCharacter();
    }

    [Fact]
    public void Replace_Input_0_Should_Return_Input_Star()
    {
        var input = "0";
        var expected = "*";

        var result = _replaceCharacter.Replace(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Replace_Input_Zero_Should_Return_Input_FullStar()
    {
        var input = "0000";
        var expected = "****";

        var result = _replaceCharacter.Replace(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Replace_Input_Hello_Should_Throw_Exception()
    {
        var input = "hello";

        Assert.Throws<KeyNotFoundException>(() => _replaceCharacter.Replace(input));
    }

    [Fact]
    public void Replace_Input_Empty_Should_Return_Empty()
    {
        var input = "";
        var result = _replaceCharacter.Replace(input);
        Assert.Empty(result);
    }
}