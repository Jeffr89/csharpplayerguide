public class BoneCrunchAttackAction : ICharacterAttackAction
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public BoneCrunchAttackAction()
    {
        Name = "Bone Crunch";

    }
    public void Run(Character character, Character target)
    {
        Random random = new Random();
        Damage = random.Next(2);
        target.GetDamage(Damage);
        Console.WriteLine($"{character.Name} used {Name} on {target.Name}");
        Console.WriteLine($"{Name} dealt {Damage} to {target.Name}");
        Console.WriteLine($"{target.Name} is now at {target.CurrentHP}/{target.MaxHP} HP.");

    }
}