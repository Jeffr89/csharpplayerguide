public class TheUncodedOne : Character
{
    public TheUncodedOne() : base("THE UNCODED ONE")
    {
        MaxHP = 15;
        CurrentHP = MaxHP;
        Actions.Add(new SkipTurnAction());
        Actions.Add(new UnravelingttackAction());
    }
}

