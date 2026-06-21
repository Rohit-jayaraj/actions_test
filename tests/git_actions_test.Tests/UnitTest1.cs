using Xunit;
using git_actions_test;

namespace git_actions_test.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ShouldReturnSum()
    {
        Assert.Equal(15, _calculator.Add(10, 5));
    }

    [Fact]
    public void Subtract_ShouldReturnDifference()
    {
        Assert.Equal(5, _calculator.Subtract(10, 5));
    }

    [Fact]
    public void Multiply_ShouldReturnProduct()
    {
        Assert.Equal(50, _calculator.Multiply(10, 5));
    }

    [Fact]
    public void Divide_ShouldReturnQuotient()
    {
        Assert.Equal(2.0, _calculator.Divide(10, 5));
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowArgumentException()
    {
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
        Assert.Equal("b", exception.ParamName);
    }
}
