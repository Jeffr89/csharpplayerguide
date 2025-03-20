public class Skeleton : Character
{
    public Skeleton() : base("SKELETON")
    {
        MaxHP = 5;
        CurrentHP = MaxHP;
        Actions.Add(new SkipTurnAction());
        Actions.Add(new BoneCrunchAttackAction());
    }
}
