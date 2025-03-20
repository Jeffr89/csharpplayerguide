using System.ComponentModel;
using System.Diagnostics.Contracts;

public class SkipTurnAction : ICharacterAction
{
    public string Name { get; set; }

    public SkipTurnAction()
    {
        Name = "Skip Turn";
    }

    public void Run(Character character)
    {
        Console.WriteLine($"{character.Name} did nothing");
    }

}
