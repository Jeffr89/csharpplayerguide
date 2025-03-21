public class UnravelingttackAction : ICharacterAttackAction
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public UnravelingttackAction()
    {
        Name = "Unraveling";

    }

    public void Run(Character character, Character target)
    {
        Random random = new Random();
        Damage = random.Next(3);
        Console.WriteLine($"{character.Name} used {Name} on {target.Name}");
        Console.WriteLine($"{Name} dealt {Damage} to {target.Name}");
        target.TakeDamage(Damage);
    }

}
