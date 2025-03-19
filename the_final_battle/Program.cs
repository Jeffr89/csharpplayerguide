
List<Character> heroes = new List<Character>();
List<Character> monsters = new List<Character>();
heroes.Add(new Skeleton());
monsters.Add(new Skeleton());
Party heroParty = new Party(heroes);
Party monsterParty = new Party(monsters);


TheFinalBattleGame theFinalBattleGame = new TheFinalBattleGame(heroParty, monsterParty);

theFinalBattleGame.Run();
