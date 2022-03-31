using Xunit;
using github_actions_test;

namespace github_actions_test_unit_tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(2, Program.Add(1, 1));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(0, Program.Subtract(1, 1));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(1, Program.Multiply(1, 1));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(1, Program.Divide(1, 1));
    }

    [Fact]
    public void Test5()
    {
        Assert.Equal(0, Program.Remainder(1, 1));
    }

    [Fact]
    public void Test6()
    {
        Assert.Equal(1, Program.Square(1));
    }

    [Fact]
    public void Test7()
    {
        Assert.Equal("65/XCF9v/9yHgOOYm2wvyUiDe+RHmbsdDoJS95wc1qQ=", Program.Sha256("Hello brother"));
    }
}