using System;

public class Shape
{
    private string color = "green";
    private bool filled = true;

    // Default constructor
    public Shape() { }

    // Constructor with parameters
    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    // Getter and Setter for color
    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    // Getter and Setter for filled
    public bool IsFilled()
    {
        return filled;
    }

    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }

    // Overriding ToString method
    public override string ToString()
    {
        return "A Shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");
    }
}

public class Circle : Shape
{
    private double radius = 1.0;

    // Default constructor
    public Circle() { }

    // Constructor with radius parameter
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Constructor with radius, color, and filled parameters
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }

    // Getter and Setter for radius
    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    // Method to get area
    public double GetArea()
    {
        return radius * radius * Math.PI;
    }

    // Method to get perimeter
    public double GetPerimeter()
    {
        return 2 * radius * Math.PI;
    }

    // Overriding ToString method
    public override string ToString()
    {
        return "A Circle with radius=" + GetRadius() + ", which is a subclass of " + base.ToString();
    }
}

public class Rectangle : Shape
{
    private double width = 1.0;
    private double length = 1.0;

    // Default constructor
    public Rectangle() { }

    // Constructor with width and length parameters
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }

    // Constructor with width, length, color, and filled parameters
    public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    // Getter and Setter for width
    public double GetWidth()
    {
        return width;
    }

    public virtual void SetWidth(double width)
    {
        this.width = width;
    }

    // Getter and Setter for length
    public double GetLength()
    {
        return length;
    }

    public virtual void SetLength(double length)
    {
        this.length = length;
    }

    // Method to get area
    public double GetArea()
    {
        return width * length;
    }

    // Method to get perimeter
    public double GetPerimeter()
    {
        return 2 * (width + length);
    }

    // Overriding ToString method
    public override string ToString()
    {
        return "A Rectangle with width=" + GetWidth() + " and length=" + GetLength() + ", which is a subclass of " + base.ToString();
    }
}

public class Square : Rectangle
{
    // Default constructor
    public Square() { }

    // Constructor with side parameter
    public Square(double side) : base(side, side) { }

    // Constructor with side, color, and filled parameters
    public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

    // Getter and Setter for side
    public double GetSide()
    {
        return GetWidth();
    }

    public void SetSide(double side)
    {
        SetWidth(side);
        SetLength(side);
    }

    // Overriding SetWidth and SetLength to maintain square shape
    public override void SetWidth(double width)
    {
        SetSide(width);
    }

    public override void SetLength(double length)
    {
        SetSide(length);
    }

    // Overriding ToString method
    public override string ToString()
    {
        return "A Square with side=" + GetSide() + ", which is a subclass of " + base.ToString();
    }
}
public class SquareTest
{
    public static void Main(string[] args)
    {
        Square square1 = new Square();
        Console.WriteLine(square1);

        Square square2 = new Square(2.3);
        Console.WriteLine(square2);

        Square square3 = new Square(5.8, "yellow", true);
        Console.WriteLine(square3);
    }
}
