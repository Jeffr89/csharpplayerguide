BlockCoordinate blockCoordinate = new BlockCoordinate(4, 3);

Console.WriteLine(blockCoordinate[0]);
Console.WriteLine(blockCoordinate[1]);


public record BlockCoordinate(int Row, int Column)
{

    public int this[int index]
    {
        get
        {
            return index switch
            {
                0 => Row,
                1 => Column,
                _ => throw new IndexOutOfRangeException("Invalid index")
            };


        }
    }

};

