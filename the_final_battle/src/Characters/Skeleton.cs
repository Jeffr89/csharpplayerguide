public class Skeleton : Character
{
    public Skeleton() : base("SKELETON")
    {
        Actions.Add(new SkipTurnAction());
    }
}

public class TrueProgrammer : Character
{
    public TrueProgrammer(string name) : base(name)
    {
        Actions.Add(new SkipTurnAction());
    }
}