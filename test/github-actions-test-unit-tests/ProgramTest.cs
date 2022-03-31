using Xunit;
using github_actions_test;
using System.Text;
using System.Security.Cryptography;

namespace github_actions_test_unit_tests;

public class ProgramTest
{
    [Fact]
    public void TestAddition()
    {
        Assert.Equal(2, Program.Add(1, 1));
    }

    [Fact]
    public void TestSubtraction()
    {
        Assert.Equal(0, Program.Subtract(1, 1));
    }

    [Fact]
    public void TestMultiplication()
    {
        Assert.Equal(1, Program.Multiply(1, 1));
    }

    [Fact]
    public void TestDivision()
    {
        Assert.Equal(1, Program.Divide(1, 1));
    }

    [Fact]
    public void TestRemainder()
    {
        Assert.Equal(0, Program.Remainder(1, 1));
    }

    [Fact]
    public void TestSquare()
    {
        Assert.Equal(1, Program.Square(1));
    }

    [Fact]
    public void TestSha256()
    {
        Assert.Equal("65/XCF9v/9yHgOOYm2wvyUiDe+RHmbsdDoJS95wc1qQ=", Program.Sha256("Hello brother"));
    }

    [Fact]
    public void TestSha256WithSalt()
    {
        string salt = "shit";
        // create bytes array from string salt
        byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

        //Assert.Equal("65/XCF9v/9yHgOOYm2wvyUiDe+RHmbsdDoJS95wc1qQ=", Program.Sha256("Hello brother", saltBytes));
    }
}