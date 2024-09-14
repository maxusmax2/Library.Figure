using FluentAssertions;
using MK.Library.Figure.Models;

namespace MK.Library.Figure.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0, 0, 0, 0)]
    [InlineData(0, 0, 5, 78.53981633974483)]
    [InlineData(0, 0, 3, 28.274333882308138)]
    [InlineData(-1, 1, 5, 78.53981633974483)]
    [InlineData(-1, 1, 3, 28.274333882308138)]
    public void CircleGetAreaWithPositiveRadius(
        double centerX,
        double centerY,
        double radius,
        double exceptedResult)
    {
        //Arrange
        var circle = new Circle(centerX, centerY, radius);

        //Act
        var area = circle.Area;

        //Assert
        area.Should().Be(exceptedResult);
    }

    [Fact]
    public void CircleGetAreaWithNegativeRadius()
    {

        //Arrange

        //Act
        var circleDelegateConstructorResult = () => new Circle(0, 0, -1);

        //Assert
        circleDelegateConstructorResult.Should().Throw<ArgumentOutOfRangeException>()
            .Which.ParamName.Should().Be("radius");
    }
}
