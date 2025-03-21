
using System.Security;

List<Party> monsterParties = new();
List<Character> heroes = new List<Character>();
List<Character> monsters1 = new List<Character>();
List<Character> monsters2 = new List<Character>();
List<Character> monsters3 = new List<Character>();



Console.WriteLine("Tell me your name True Programmer!");
string input = Console.ReadLine();
heroes.Add(new TrueProgrammer(input.ToUpper()));
monsters1.Add(new Skeleton());
monsters2.Add(new Skeleton());
monsters2.Add(new Skeleton());
monsters3.Add(new TheUncodedOne());
Console.WriteLine();

Console.WriteLine("""
Which kind of game would you like to play?
1 - Player vs Player
2 - Player vs Computer
3 - Computer vs Computer
""");

int gameType = int.Parse(Console.ReadLine());
Party.PlayerType player1 = Party.PlayerType.Computer;
Party.PlayerType player2 = Party.PlayerType.Computer;
switch (gameType)
{
    case 1:
        player1 = Party.PlayerType.Human;
        player2 = Party.PlayerType.Human;
        break;
    case 2:
        player1 = Party.PlayerType.Human;
        player2 = Party.PlayerType.Computer;
        break;
    case 3:
        player1 = Party.PlayerType.Computer;
        player2 = Party.PlayerType.Computer;
        break;

}
Party heroParty = new Party(heroes, player1);
Party monsterParty1 = new Party(monsters1, player2);
Party monsterParty2 = new Party(monsters2, player2);
Party monsterParty3 = new Party(monsters3, player2);
monsterParties.Add(monsterParty1);
monsterParties.Add(monsterParty2);
monsterParties.Add(monsterParty3);
Console.Clear();

TheFinalBattleGameBattleSeries theFinalBattleGame = new(heroParty, monsterParties);
theFinalBattleGame.Run();
