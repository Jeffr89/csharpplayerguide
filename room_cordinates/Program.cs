


Coordinate a = new Coordinate(5, 5);

Coordinate b = new Coordinate(52, 62);

Console.WriteLine(a.isAdjacent(b));





public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool isAdjacent(Coordinate coordinate)
    {
        if ((coordinate.Row == Row) && (coordinate.Column == Column)) return false;
        if ((coordinate.Row <= Row + 1) && (coordinate.Row >= Row - 1) && (coordinate.Column <= Column + 1) && (coordinate.Column >= Column - 1))
        {
            return true;
        }

        return false;
    }
}