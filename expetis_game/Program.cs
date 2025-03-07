
Player player1 = new Player(1);
Player player2 = new Player(2);

ExeptiGame exeptiGame = new ExeptiGame(player1, player2);

exeptiGame.Run();




public class ExeptiGame
{
    public int OatMealCookie { get; }
    public List<int>? NumbersPicked { get; set; }

    public List<Player> PlayerList { get; }

    public ExeptiGame(params List<Player> players)
    {
        Random random = new Random();
        OatMealCookie = random.Next(10);
        PlayerList = players;
        NumbersPicked = new List<int>();
    }

    public void GameRound(Player player)
    {
        int input;
        while (true)
        {
            Console.Write($"Player {player.PlayerNumber}, choose a cookie number (0 to 9): ");
            if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out input))
            {
                Console.WriteLine();
                Console.WriteLine("Insert a number between 0 and 9!");
                continue;
            }
            else if (NumbersPicked.Contains(input))
            {
                Console.WriteLine();
                Console.WriteLine("This number has been already chosen!");
                continue;
            }
            else
            {
                NumbersPicked.Add(input);
                if (input == OatMealCookie) throw new ArgumentException();
                break;
            }
        }
    }

    public void Run()
    {
        int index = 0;
        while (true)
        {
            try
            {
                GameRound(PlayerList[index]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine();
                Console.WriteLine($"Player {PlayerList[index].PlayerNumber} won!");
                return;
            }

            index = (index + 1) % PlayerList.Count;
            Console.WriteLine();
        }

    }

}

public class Player
{
    public int PlayerNumber { get; }

    public Player(int number) => PlayerNumber = number;

}
