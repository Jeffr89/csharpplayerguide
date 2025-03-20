public class TrueProgrammer : Character
{
    public TrueProgrammer(string name) : base(name)
    {
        MaxHP = 25;
        CurrentHP = MaxHP;
        Actions.Add(new SkipTurnAction());
        Actions.Add(new PunchAttackAction());
    }
}