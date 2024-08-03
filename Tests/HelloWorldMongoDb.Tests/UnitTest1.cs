using FluentAssertions;

namespace HelloWorldMongoDb.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        const bool expected = true;

        // Act
        var value = true;

        // Assert
        value.Should().Be(expected);
    }
}
