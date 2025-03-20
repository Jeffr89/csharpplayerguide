public class TheFinalBattleGame
{
    public Party Heroes;
    public Party Monsters { get; private set; }

    public Character MonsterToPlay { get; private set; }
    public Party partyToPlay { get; private set; }

    public TheFinalBattleGame(Party heroes, Party monsters)
    {
        Heroes = heroes;
        Monsters = monsters;
        partyToPlay = Heroes;
    }

    public void Run()
    {

        while (!BattleIsOver())
        {
            PlayRound(partyToPlay.GetNextMemberToPlay(), partyToPlay.ControlledBy);
            Thread.Sleep(500);
            Console.WriteLine();
            partyToPlay = partyToPlay == Heroes ? Monsters : Heroes;

        }

        CheckWinner();
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
            actionNumber = 1;
        }
        character.PlayAction(actionNumber, this);


    }

    public bool BattleIsOver()
    {
        Console.WriteLine(Monsters.MemberCount);
        if ((Heroes.MemberCount == 0) || (Monsters.MemberCount == 0)) return true;
        else return false;
    }

    public void CheckWinner()
    {
        if ((Monsters.MemberCount == 0))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Heroes won! The Uncoded One was defeated!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Heroes lost and the Uncoded One's forces has prevailed");
        }
    }

}



