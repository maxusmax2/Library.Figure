using MK.Library.Figure.Models.Base;

namespace MK.Library.Figure.Extensions;

public static class PointExtensions
{
    public static double GetDistanceSquared(this Point pointOne, Point pointTwo) =>
        Math.Pow(pointTwo.X - pointOne.X, 2) + Math.Pow(pointTwo.Y - pointOne.Y, 2);
}
