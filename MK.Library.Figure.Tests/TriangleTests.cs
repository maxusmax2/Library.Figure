using FluentAssertions;
using MK.Library.Figure.Models;

namespace MK.Library.Figure.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0)]
    [InlineData(1, 1, 2, 4, 7, 3, 8)]
    [InlineData(-1, -1, -2, -4, -7, -3, 8)]
    [InlineData(-1, 1, -2, 4, -7, 3, 8)]
    public void TriangleWithCoordinatesMixValuesGetArea(
        double pointOneX,
        double pointOneY,
        double pointTwoX,
        double pointTwoY,
        double pointThreeX,
        double pointThreeY,
        double exceptedResult)
    {
        //Arrange
        var triangle = new Triangle(
            pointOneX, pointOneY,
            pointTwoX, pointTwoY,
            pointThreeX, pointThreeY);

        //Act
        var area = triangle.Area;

        //Assert
        area.Should().Be(exceptedResult);
    }

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, true)]
    [InlineData(1, 1, 1, 4, 4, 1, true)]
    [InlineData(2, 2, 1, 4, 4, 1, false)]
    [InlineData(-1, -1, -1, 4, 4, -1, true)]
    [InlineData(-2, -2, -1, 4, 4, -1, false)]

    public void TriangleWithCoordinatesMixValuesIsRectangular(double pointOneX,
        double pointOneY,
        double pointTwoX,
        double pointTwoY,
        double pointThreeX,
        double pointThreeY,
        bool exceptedResult)
    {
        //Arrange
        var triangle = new Triangle(
            pointOneX, pointOneY,
            pointTwoX, pointTwoY,
            pointThreeX, pointThreeY);

        //Act
        var isRectangular = triangle.IsRectangular;

        //Assert
        isRectangular.Should().Be(exceptedResult);
    }
}
