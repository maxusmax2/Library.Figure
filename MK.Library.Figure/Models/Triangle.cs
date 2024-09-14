using MK.Library.Figure.Extensions;
using MK.Library.Figure.Models.Base;

namespace MK.Library.Figure.Models;

public class Triangle : IFigure
{
    public Triangle(
        Point pointOne,
        Point pointTwo,
        Point pointThree)
    {
        PointOne = pointOne;
        PointTwo = pointTwo;
        PointThree = pointThree;
    }

    public Triangle(
        double pointOneX,
        double pointOneY,
        double pointTwoX,
        double pointTwoY,
        double pointThreeX,
        double pointThreeY)
    {
        PointOne = new Point(pointOneX, pointOneY);
        PointTwo = new Point(pointTwoX, pointTwoY);
        PointThree = new Point(pointThreeX, pointThreeY);
    }

    public Point PointOne { get; }
    public Point PointTwo { get; }
    public Point PointThree { get; }

    public double Area
    {
        get
        {
            if (_area is null)
                _area = Math.Abs(PointOne.X * (PointTwo.Y - PointThree.Y)
                    + PointTwo.X * (PointThree.Y - PointOne.Y)
                    + PointThree.X * (PointOne.Y - PointTwo.Y)) / 2;
            return _area.Value;
        }
    }

    public bool IsRectangular
    {
        get
        {
            if (_isRectangular is null)
                _isRectangular =
                    TriangleSideOneTwoDistanceSquared + TriangleSideTwoThreeDistanceSquared == TriangleSideThreeOneDistanceSquared ||
                    TriangleSideTwoThreeDistanceSquared + TriangleSideThreeOneDistanceSquared == TriangleSideOneTwoDistanceSquared ||
                    TriangleSideOneTwoDistanceSquared + TriangleSideThreeOneDistanceSquared == TriangleSideTwoThreeDistanceSquared;
            return _isRectangular.Value;
        }
    }

    public double TriangleSideOneTwoDistanceSquared
    {
        get
        {
            if (_triangleSideOneTwoDistanceSquared is null)
                _triangleSideOneTwoDistanceSquared = PointOne.GetDistanceSquared(PointTwo);
            return _triangleSideOneTwoDistanceSquared.Value;
        }
    }

    public double TriangleSideTwoThreeDistanceSquared
    {
        get
        {
            if (_triangleSideTwoThreeDistanceSquared is null)
                _triangleSideTwoThreeDistanceSquared = PointTwo.GetDistanceSquared(PointThree);
            return _triangleSideTwoThreeDistanceSquared.Value;
        }
    }

    public double TriangleSideThreeOneDistanceSquared
    {
        get
        {
            if (_triangleSideThreeOneDistanceSquared is null)
                _triangleSideThreeOneDistanceSquared = PointThree.GetDistanceSquared(PointOne);
            return _triangleSideThreeOneDistanceSquared.Value;
        }
    }

    private double? _area;
    private bool? _isRectangular;
    private double? _triangleSideOneTwoDistanceSquared;
    private double? _triangleSideTwoThreeDistanceSquared;
    private double? _triangleSideThreeOneDistanceSquared;
}
