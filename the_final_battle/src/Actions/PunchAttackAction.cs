public class PunchAttackAction : ICharacterAttackAction
{
    public string Name { get; set; }
    public PunchAttackAction()
    {
        Name = "Punch";
    }

    public void Run(Character character, Character target)
    {
        Console.WriteLine($"{character.Name} used {Name} on {target.Name}");
    }

}
