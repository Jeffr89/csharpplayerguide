public class TheFinalBattleGameBattleSeries
{
    public Party Heroes;
    public List<Party> MonstersParties { get; private set; }



    public TheFinalBattleGameBattleSeries(Party heroes, List<Party> monsterParties)
    {
        Heroes = heroes;
        MonstersParties = monsterParties;

    }



    public void Run()
    {

        foreach (var monsterParty in MonstersParties.ToList())
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            TheFinalBattleGameSingleBattle singleBattle = new(Heroes, monsterParty);
            singleBattle.Run();
            if (singleBattle.CheckWinner() == Winner.Hero)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                MonstersParties.Remove(monsterParty);
                Console.WriteLine("Heroes won! The Uncoded One's party was defeated!");
                Console.WriteLine("You can advance to the next party of monsters!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Heroes lost and the Uncoded One's forces has prevailed");
                Console.WriteLine("Game Over!");
                break;
            }
        }




    }
    public bool BattleSeriesIsOver()
    {
        if ((Heroes.MemberCount == 0) || (MonstersParties.Count == 0)) return true;
        else return false;
    }


}






