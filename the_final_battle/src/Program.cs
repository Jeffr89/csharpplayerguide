List<Party> monsterParties = new();
List<Character> heroes = new List<Character>();
List<Character> monsters1 = new List<Character>();
List<Character> monsters2 = new List<Character>();



Console.WriteLine("Tell me your name True Programmer!");
string input = Console.ReadLine();
heroes.Add(new TrueProgrammer(input.ToUpper()));
monsters1.Add(new Skeleton());
monsters2.Add(new Skeleton());
monsters2.Add(new Skeleton());


Party heroParty = new Party(heroes, Party.PlayerType.Computer);
Party monsterParty1 = new Party(monsters1, Party.PlayerType.Computer);
Party monsterParty2 = new Party(monsters2, Party.PlayerType.Computer);
monsterParties.Add(monsterParty1);
monsterParties.Add(monsterParty2);
Console.Clear();

TheFinalBattleGameBattleSeries theFinalBattleGame = new(heroParty, monsterParties);
theFinalBattleGame.Run();
