using System;
using GeometryShapes;


namespace GeometryTests;

// SquareTests

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var square = new Square(5);
        var result = square.CalculatePerimeter();
        Assert.AreEqual(20, result);
    }
}

    // Rectangle Tests
    
[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestArea()
    {
        var rectangle = new Rectangle(6, 4);

        var result = rectangle.CalculateArea();

        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var rectangle = new Rectangle(6, 4);

        var result = rectangle.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }
}


    // Triangle Tests

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
        var triangle = new Triangle(3, 4, 5);

        var result = triangle.CalculateArea();

        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var triangle = new Triangle(3, 4, 5);

        var result = triangle.CalculatePerimeter();

        Assert.AreEqual(12, result);
    }
}