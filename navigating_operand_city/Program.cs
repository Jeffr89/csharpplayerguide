BlockCoordinate blockCoordinate = new BlockCoordinate(4, 3);
BlockOffset blockOffset = new BlockOffset(2, 0);

Console.WriteLine(blockCoordinate + blockOffset);
Console.WriteLine(blockCoordinate + Direction.East);






public record BlockCoordinate(int Row, int Column)
{



    public static BlockCoordinate operator +(BlockCoordinate blockCoordinate, BlockOffset blockOffset)
    {
        return new BlockCoordinate(blockCoordinate.Row + blockOffset.RowOffset, blockCoordinate.Column + blockOffset.ColumnOffset);
    }

    public static BlockCoordinate operator +(BlockCoordinate blockCoordinate, Direction direction)
    {
        return direction switch
        {
            Direction.North => new BlockCoordinate(blockCoordinate.Row + 1, blockCoordinate.Column),
            Direction.South => new BlockCoordinate(blockCoordinate.Row - 1, blockCoordinate.Column),
            Direction.East => new BlockCoordinate(blockCoordinate.Row, blockCoordinate.Column + 1),
            Direction.West => new BlockCoordinate(blockCoordinate.Row, blockCoordinate.Column - 1)
        };
    }
};


public record BlockOffset(int RowOffset, int ColumnOffset);
public enum Direction { North, East, South, West };
