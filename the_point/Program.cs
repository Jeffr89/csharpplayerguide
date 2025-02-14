


Point a = new Point(2, 3);
Point b = new Point(-4, 0);

Console.WriteLine($"({a.X},{a.Y})");

Console.WriteLine($"({b.X},{b.Y})");

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point() : this(0, 0) { }
}
