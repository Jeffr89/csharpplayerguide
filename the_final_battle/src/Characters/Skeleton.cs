public class Skeleton : Character
{
    public Skeleton() : base("SKELETON")
    {
        Actions.Add(new SkippingTurnAction());
    }
}

