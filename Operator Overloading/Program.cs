Point point = new(x: 52, y: 36);
Point point1 = new() { X = 1, Y = 0 };
Console.WriteLine(point1.Equals(point));



if (point1)
{
    Console.WriteLine("Not on coordinates start");
}
else
{
    Console.WriteLine("On coordinates start");
}
//Console.WriteLine(point++);
//Console.WriteLine(point + point1);
//Console.WriteLine(point1 * 5);

class Point
{
    public Point()
    {
        X = default;
        Y = default;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point (X :{X}, Y: {Y})";
    }
    public int X { get; set; }
    public int Y { get; set; }


    // Unary operators overloading
    public static Point operator ++(Point p)
    {
        p.X++;
        p.Y++;
        return p;
    }

    public static Point operator --(Point p)
    {
        p.X--;
        p.Y--;
        return p;
    }

    public static Point operator -(Point p)
    {
        return new Point(-p.X, -p.Y);
    }

    // Binary operators overloading
    public static Point operator +(Point left, Point right)
    {
        return new Point
        {
            X = left.X + right.X,
            Y = left.Y + right.Y
        };
    }

    public static Point operator -(Point left, Point right)
    {
        return new Point
        {
            X = left.X - right.X,
            Y = left.Y - right.Y
        };
    }

    public static Point operator *(Point left, int value)
    {
        return new Point
        {
            X = left.X * value,
            Y = left.Y * value
        };
    }

    public static Point operator *(int value, Point left)
    {
        return new Point
        {
            X = left.X * value,
            Y = left.Y * value
        };
    }

    public override bool Equals(object? obj)
    {
        return this.ToString() == obj.ToString();
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Point left, Point right)
    {
        return !(left == right);
    }

    public static bool operator >(Point left, Point right)
    {
        return
            Math.Sqrt(Math.Pow(left.X, 2) + Math.Pow(left.Y, 2)) >
            Math.Sqrt(Math.Pow(right.X, 2) + Math.Pow(right.Y, 2));
    }

    public static bool operator <(Point left, Point right)
    {
        return
            Math.Sqrt(Math.Pow(left.X, 2) + Math.Pow(left.Y, 2)) <
            Math.Sqrt(Math.Pow(right.X, 2) + Math.Pow(right.Y, 2));
    }

    public static bool operator true(Point point)
    {
        return point.X != 0 || point.Y != 0 ? true : false; 
    }
    public static bool operator false(Point point)
    {
        return point.X == 0 && point.Y == 0 ? true : false;
    }

    public static Point operator |(Point left, Point right)
    {
        if ((left.X != 0 || left.Y != 0) || (right.X != 0 || right.Y != 0))
        {
            return right;
        }
        return new Point();
    }

    public static Point operator &(Point left, Point right)
    {
        if ((left.X != 0 && left.Y != 0) && (right.X != 0 && right.Y != 0))
        {
            return right;
        }
        return new Point();
    }


}