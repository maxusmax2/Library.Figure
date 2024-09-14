# Library.Figure
This library provides functionality for obtaining the area of various figures
with such as:
1) triangle;
2) circle;

Also provides, a point class, in two-dimensional space
## Triangle
Triangle object can be created by specifying 3 points in two-dimensional space. You can get the area of ​​an object and also find out whether it is a rectangle:

```
var triangle = new Triangle(
    1, 1,
    2, 4,
    7, 3);
var area = triangle.Area; // 8
var isRectangular = triangle.IsRectangular; // false
```
You can also create a triangle using the constructor with point:
```
var triangle = new Triangle(
    new Point(1, 1),
    new Point(2, 4),
    new Point(7, 3));
var area = triangle.Area; // 8
var isRectangular = triangle.IsRectangular; // false

```

## Circle
A circle object can be created by specifying a center point and a radius value:
```
var circle = new Circle(0, 0, 5);
var area = circle.Area; // 78.53981633974483
```
You can also create a circle using the constructor with point:
```
var circle = new Circle(new Point(0, 0), 5);
var area = circle.Area; // 78.53981633974483
```

## Point
You can also get the square of the distance between points:
```
var pointOne = new Point(1, 1);
var pointTwo = new Point(1, 4);
var distanceSquared = pointOne.GetDistanceSquared(pointTwo); //9
```
