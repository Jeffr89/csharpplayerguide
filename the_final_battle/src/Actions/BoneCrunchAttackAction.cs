public class BoneCrunchAttackAction : ICharacterAttackAction
{
    public string Name { get; set; }
    public BoneCrunchAttackAction()
    {
        Name = "Bone Crunch";
    }
    public void Run(Character character, Character target)
    {
        Console.WriteLine($"{character.Name} used {Name} on {target.Name}");
    }
}