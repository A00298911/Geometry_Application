
namespace GeometryShapes;

// IShape.cs
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

// Square
public class Square : IShape
{
    private readonly double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double CalculateArea()
    {
        return sideLength * sideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * sideLength;
    }
}

    // Rectangle
public class Rectangle : IShape
{
    private readonly double length;
    private readonly double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}


// Triangle
public class Triangle : IShape
{
    private readonly double side1;
    private readonly double side2;
    private readonly double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}