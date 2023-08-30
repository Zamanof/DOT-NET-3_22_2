//Point point = new Point();
//Console.WriteLine(point.X);
//Console.WriteLine(point.Y);
//Console.WriteLine(point.Bulbul);

//Console.WriteLine();

//var pointBlank = new Point(25, 23, true);
//Console.WriteLine(pointBlank.X);
//Console.WriteLine(pointBlank.Y);
//Console.WriteLine(pointBlank.Bulbul);

//Console.WriteLine();

Point point1 = new(69, 89, false);
Point point2 = point1;

Console.WriteLine(point1.X);
Console.WriteLine(point1.Y);
Console.WriteLine(point1.Bulbul);
Console.WriteLine();
Console.WriteLine(point2.X);
Console.WriteLine(point2.Y);
Console.WriteLine(point2.Bulbul);
Console.WriteLine();
Console.WriteLine();

point2.X = 156;

Console.WriteLine(point1.X);
Console.WriteLine(point1.Y);
Console.WriteLine(point1.Bulbul);
Console.WriteLine();
Console.WriteLine(point2.X);
Console.WriteLine(point2.Y);
Console.WriteLine(point2.Bulbul);
Console.WriteLine();
Console.WriteLine();
struct Point
{
    public int X;
    public int Y;
    public bool Bulbul;

    public Point(int x, int y, bool bulbul)
    {
        X = x;
        Y = y;
        Bulbul = bulbul;
    }
}