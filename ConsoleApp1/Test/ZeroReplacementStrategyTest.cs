using ConsoleApp1.Dictionary;
using ConsoleApp1.Strategy;
using Xunit;

namespace ConsoleApp1.Test;

public class ZeroReplacementStrategyTest
{
    private readonly ZeroReplacementStrategy _zeroReplacementStrategy;

    public ZeroReplacementStrategyTest()
    {
        _zeroReplacementStrategy = new ZeroReplacementStrategy();
    }

    [Fact]
    public void Replace_Input_0_Should_Return_Input_Star()
    {
        var input = "0";
        var expected = "*";

        var result = _zeroReplacementStrategy.Replace(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Replace_Input_Zero_Should_Return_Input_FullStar()
    {
        var input = "0000";
        var expected = "****";

        var result = _zeroReplacementStrategy.Replace(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Replace_Input_Hello_Should_Throw_Exception()
    {
        var input = "hello";

        Assert.Throws<KeyNotFoundException>(() => _zeroReplacementStrategy.Replace(input));
    }

    [Fact]
    public void Replace_Input_Empty_Should_Return_Empty()
    {
        var input = "";
        var result = _zeroReplacementStrategy.Replace(input);
        Assert.Empty(result);
    }

    [Fact]
    public void Replace_Input_GraterThanZero_ReturnSameInput()
    {
        var input = "1111";
        var expected = "1111";

        var result = _zeroReplacementStrategy.Replace(input);

        Assert.Equal(expected, result);
    }
}