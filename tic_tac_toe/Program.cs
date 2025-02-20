
TicTacToeGame ticTacToe = new TicTacToeGame();
ticTacToe.Run();

class Player
{

    public Cell PlayerSymbol { get; }

    public Player(Cell playerSymbol)
    {
        PlayerSymbol = playerSymbol;

    }

    public void PickSquare(Board board)
    {
        while (true)
        {
            Console.WriteLine("What square do you want to play in?");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine();
            (int, int) square = consoleKey switch
            {
                ConsoleKey.D7 => (0, 0),
                ConsoleKey.D8 => (0, 1),
                ConsoleKey.D9 => (0, 2),
                ConsoleKey.D4 => (1, 0),
                ConsoleKey.D5 => (1, 1),
                ConsoleKey.D6 => (1, 2),
                ConsoleKey.D1 => (2, 0),
                ConsoleKey.D2 => (2, 1),
                ConsoleKey.D3 => (2, 2),
            };
            (int x, int y) = square;
            if (board.WriteSymbol(x, y, PlayerSymbol))
            {
                break;
            }
            else
            {
                Console.WriteLine("Square unavailable");
            }
        }
    }

}

class Board
{

    public Cell[,] board { get; private set; } = new Cell[3, 3];

    public void DisplayBoard()
    {
        Console.WriteLine($"""
         {(board[0, 0] != Cell.Empty ? board[0, 0] : ' ')} | {(board[0, 1] != Cell.Empty ? board[0, 1] : ' ')} | {(board[0, 2] != Cell.Empty ? board[0, 2] : ' ')}
        ---+---+---
         {(board[1, 0] != Cell.Empty ? board[1, 0] : ' ')} | {(board[1, 1] != Cell.Empty ? board[1, 1] : ' ')} | {(board[1, 2] != Cell.Empty ? board[1, 2] : ' ')}
        ---+---+---
         {(board[2, 0] != Cell.Empty ? board[2, 0] : ' ')} | {(board[2, 1] != Cell.Empty ? board[2, 1] : ' ')} | {(board[2, 2] != Cell.Empty ? board[2, 2] : ' ')}
        """);
    }

    public bool WriteSymbol(int x, int y, Cell playerSymbol)
    {
        if (board[x, y] == Cell.Empty)
        {
            board[x, y] = playerSymbol;
            return true;
        }
        else return false;
    }



}

class TicTacToeGame
{

    public void Run()
    {
        Player playerOne = new Player(Cell.X);
        Player playerTwo = new Player(Cell.O);
        Board board = new Board();
        Player currentPlayer = playerOne;
        int turn = 0;
        while (turn < 9)
        {
            Console.Clear();
            Console.WriteLine($"It is {currentPlayer.PlayerSymbol}'s turn");
            board.DisplayBoard();
            currentPlayer.PickSquare(board);
            if (HasWon(board, currentPlayer))
            {
                Console.Clear();
                board.DisplayBoard();
                Console.WriteLine($"Player {currentPlayer.PlayerSymbol} WON!");
                return;
            }
            currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
            turn++;
        }
        Console.Clear();
        board.DisplayBoard();
        Console.WriteLine("DRAW!");
        return;

    }
    public bool HasWon(Board board, Player player)
    {
        // Controllo righe
        if ((board.board[0, 0] == player.PlayerSymbol && board.board[0, 1] == player.PlayerSymbol && board.board[0, 2] == player.PlayerSymbol) ||
            (board.board[1, 0] == player.PlayerSymbol && board.board[1, 1] == player.PlayerSymbol && board.board[1, 2] == player.PlayerSymbol) ||
            (board.board[2, 0] == player.PlayerSymbol && board.board[2, 1] == player.PlayerSymbol && board.board[2, 2] == player.PlayerSymbol)) return true;

        // Controllo colonne
        if ((board.board[0, 0] == player.PlayerSymbol && board.board[1, 0] == player.PlayerSymbol && board.board[2, 0] == player.PlayerSymbol) ||
            (board.board[0, 1] == player.PlayerSymbol && board.board[1, 1] == player.PlayerSymbol && board.board[2, 1] == player.PlayerSymbol) ||
            (board.board[0, 2] == player.PlayerSymbol && board.board[1, 2] == player.PlayerSymbol && board.board[2, 2] == player.PlayerSymbol)) return true;

        // Controllo diagonali
        if ((board.board[0, 0] == player.PlayerSymbol && board.board[1, 1] == player.PlayerSymbol && board.board[2, 2] == player.PlayerSymbol) ||
            (board.board[0, 2] == player.PlayerSymbol && board.board[1, 1] == player.PlayerSymbol && board.board[2, 0] == player.PlayerSymbol)) return true;

        return false;
    }

}

enum Cell
{
    Empty,
    X,
    O
}