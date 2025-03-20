public class Skeleton : Character
{
    public Skeleton() : base("SKELETON")
    {
        Actions.Add(new SkipTurnAction());
        Actions.Add(new BoneCrunchAttackAction());
    }
}
