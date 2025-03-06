
FountainOfObjectsGame fountainOfObjectsGame = new FountainOfObjectsGame();

fountainOfObjectsGame.Run();



public class FountainOfObjectsGame
{
    public void Run()
    {
        DateTime startGameTime = DateTime.Now;
        DateTime endGameTime;
        Player player = new Player();

        Console.WriteLine("""
        Hi adventurer!
        Would you play in a small, a medium or a large world!?
        """);

        string input = Console.ReadLine();

        GridOfRooms gridOfRooms = input switch
        {
            "small" => new GridOfRooms(4),
            "medium" => new GridOfRooms(6),
            "large" => new GridOfRooms(8)
        };



        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You are in the room at (Row={player.rowPosition}, Column={player.columnPosition})");
            if (GameWon(gridOfRooms, player)) break;
            Console.ForegroundColor = ConsoleColor.Cyan;
            gridOfRooms.Rooms[player.columnPosition, player.rowPosition].RoomNarrative();
            player.Move(gridOfRooms);
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!");
        endGameTime = DateTime.Now;
        TimeSpan elapsedTime = endGameTime - startGameTime;
        Console.WriteLine($"Time elapsed: {elapsedTime} ");

    }

    public bool GameWon(GridOfRooms gridOfRooms, Player player)
    {

        if ((gridOfRooms.Rooms[player.columnPosition, player.rowPosition] is EntranceRoom entranceRoom) && gridOfRooms.FountainRoom.FountainStatus == true)
        {
            return true;
        }
        return false;
    }

}

public class Player
{
    public int rowPosition { get; private set; } = 0;
    public int columnPosition { get; private set; } = 0;

    public void Move(GridOfRooms gridOfRooms)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("What do you want to do? ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        string input = Console.ReadLine();
        switch (input)
        {
            case "move north":
                {
                    MoveNorth(gridOfRooms);
                    break;
                }
            case "move south":
                {
                    MoveSouth(gridOfRooms);
                    break;
                }
            case "move east":
                {
                    MoveEast(gridOfRooms);
                    break;
                }
            case "move west":
                {
                    MoveWest(gridOfRooms);
                    break;
                }
            case "enable fountain":
                {
                    if (gridOfRooms.Rooms[columnPosition, rowPosition] is FountainRoom fountainRoom)
                    {
                        fountainRoom.TurnOnFountain();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The Fountain of Objects is not here!");
                    }
                    break;
                }

        }

    }

    public void MoveNorth(GridOfRooms gridOfRooms)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        if (gridOfRooms.ValidPosition(columnPosition, rowPosition - 1)) rowPosition--;
        else Console.WriteLine("You cannot move in this direction");
    }
    public void MoveSouth(GridOfRooms gridOfRooms)
    {
        if (gridOfRooms.ValidPosition(columnPosition, rowPosition + 1)) rowPosition++;
        else Console.WriteLine("You cannot move in this direction");
    }
    public void MoveEast(GridOfRooms gridOfRooms)
    {
        if (gridOfRooms.ValidPosition(columnPosition + 1, rowPosition)) columnPosition++;
        else Console.WriteLine("You cannot move in this direction");
    }
    public void MoveWest(GridOfRooms gridOfRooms)
    {
        if (gridOfRooms.ValidPosition(columnPosition - 1, rowPosition)) columnPosition--;
        else Console.WriteLine("You cannot move in this direction");
    }
}

public interface IBaseRoom
{
    public void RoomNarrative();

}
public class EmptyRoom : IBaseRoom
{
    public void RoomNarrative() { }

}

public class FountainRoom : IBaseRoom
{
    public bool FountainStatus { get; set; } = false;

    public void RoomNarrative()
    {

        if (!FountainStatus) Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        else Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
    }

    public void TurnOnFountain()
    {
        FountainStatus = true;
    }


}
public class EntranceRoom : IBaseRoom
{
    public void RoomNarrative()
    {
        Console.WriteLine("You see light coming from the cavern entrance.");
    }
}

public class GridOfRooms
{
    public IBaseRoom[,] Rooms { get; }
    public int GridSide { get; }

    public FountainRoom FountainRoom { get; }
    public EntranceRoom EntranceRoom { get; }

    public GridOfRooms(int grid)
    {
        GridSide = grid;
        Rooms = new IBaseRoom[GridSide, GridSide];
        FountainRoom = new FountainRoom();
        EntranceRoom = new EntranceRoom();

        Rooms[0, 0] = EntranceRoom;
        Rooms[2, 0] = FountainRoom;
        for (int i = 0; i < GridSide; i++)
        {
            for (int j = 0; j < GridSide; j++)
            {
                if (Rooms[i, j] == null)
                    Rooms[i, j] = new EmptyRoom();
            }
        }
    }

    public bool ValidPosition(int column, int row)
    {
        if ((column >= 0) && (column < GridSide) && (row >= 0) && (row < GridSide)) return true;
        else return false;
    }
}

public record Position(int X = 0, int Y = 0);

public enum RoomType
{
    Empty,
    Fountain
}