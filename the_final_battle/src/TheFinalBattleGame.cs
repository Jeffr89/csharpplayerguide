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
            PlayRound(partyToPlay.GetNextMemberToPlay());
            Thread.Sleep(500);
            Console.WriteLine();

            partyToPlay = partyToPlay == Heroes ? Monsters : Heroes;

        }
    }

    public void PlayRound(Character character)
    {
        Console.WriteLine($"It is {character.Name} turn...");
        character.PlayAction();
    }

}



