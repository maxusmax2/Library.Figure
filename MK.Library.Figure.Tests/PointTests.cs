using FluentAssertions;
using MK.Library.Figure.Extensions;
using MK.Library.Figure.Models.Base;

namespace MK.Library.Figure.Tests;

public class PointTests
{
    [Theory]
    [InlineData(0, 0, 0, 0, 0)]
    [InlineData(1, 1, 1, 4, 9)]
    [InlineData(-1, -1, -1, 4, 25)]
    public void PointGetDistanceSquared(
        double pointOneX,
        double pointOneY,
        double pointTwoX,
        double pointTwoY,
        double exceptedResult)
    {
        //Arrange
        var pointOne = new Point(pointOneX, pointOneY);
        var pointTwo = new Point(pointTwoX, pointTwoY);

        //Act
        var distanceSquared = pointOne.GetDistanceSquared(pointTwo);

        //Assert
        distanceSquared.Should().Be(exceptedResult);
    }
}
