public class PunchAttackAction : ICharacterAttackAction
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public PunchAttackAction()
    {
        Name = "Punch";
        Damage = 1;

    }

    public void Run(Character character, Character target)
    {
        target.GetDamage(Damage);
        Console.WriteLine($"{character.Name} used {Name} on {target.Name}");
        Console.WriteLine($"{Name} dealt {Damage} to {target.Name}");
        Console.WriteLine($"{target.Name} is now at {target.CurrentHP}/{target.MaxHP} HP.");
    }

}
