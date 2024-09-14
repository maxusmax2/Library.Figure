using MK.Library.Figure.Models.Base;

namespace MK.Library.Figure.Models;

public class Circle : IFigure
{
    public Circle(
        double centerX,
        double centerY,
        double radius)
    {
        Center = new Point(centerX, centerY);

        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius));
        Radius = radius;
    }

    public Point Center { get; }
    public double Radius { get; }

    public double Area
    {
        get
        {
            if (_area is null)
                _area = Math.Pow(Radius, 2) * Math.PI;
            return _area.Value;
        }
    }

    private double? _area;
}
