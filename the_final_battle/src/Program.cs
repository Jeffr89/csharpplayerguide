
List<Character> heroes = new List<Character>();
List<Character> monsters = new List<Character>();



Console.WriteLine("Tell me your name True Programmer!");
string input = Console.ReadLine();
heroes.Add(new TrueProgrammer(input.ToUpper()));
monsters.Add(new Skeleton());

Party heroParty = new Party(heroes, Party.PlayerType.Human);
Party monsterParty = new Party(monsters, Party.PlayerType.Human);

Console.Clear();


TheFinalBattleGame theFinalBattleGame = new TheFinalBattleGame(heroParty, monsterParty);


theFinalBattleGame.Run();
