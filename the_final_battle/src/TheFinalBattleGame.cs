public class TheFinalBattleGame
{
    public Party Heroes;
    public Party Monsters { get; private set; }

    public Character MonsterToPlay { get; private set; }

    public TheFinalBattleGame(Party heroes, Party monsters)
    {
        Heroes = heroes;
        Monsters = monsters;
    }

    public void Run()
    {
        Party partyToPlay = Heroes;
        while (true)
        {
            PlayRound(partyToPlay.GetNextMemberToPlay(), partyToPlay.ControlledBy);
            Thread.Sleep(500);
            Console.WriteLine();

            partyToPlay = partyToPlay == Heroes ? Monsters : Heroes;

        }
    }

    public void PlayRound(Character character, Party.PlayerType playerType)
    {
        Console.WriteLine($"It is {character.Name} turn...");
        int actionNumber;
        if (playerType == Party.PlayerType.Human)
        {
            Console.WriteLine("Choose your action:");
            for (int i = 0; i < character.Actions.Count; i++)
            {
                Console.WriteLine($"{i} - {character.Actions[i].Name}");
            }
            actionNumber = int.Parse(Console.ReadLine());
        }
        else
        {
            actionNumber = 0;
        }
        character.PlayAction(actionNumber);
    }

}



