public class SkippingTurnAction : ICharacterAction
{
    public void Run(Character character)
    {
        Console.WriteLine($"{character.Name} did nothing");
    }
}
