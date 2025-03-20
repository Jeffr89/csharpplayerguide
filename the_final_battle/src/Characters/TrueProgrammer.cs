public class TrueProgrammer : Character
{
    public TrueProgrammer(string name) : base(name)
    {
        Actions.Add(new SkipTurnAction());
        Actions.Add(new PunchAttackAction());
    }
}