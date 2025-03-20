public abstract class Character
{
    public string Name { get; protected set; }
    public int MaxHP { get; protected set; }
    public int CurrentHP { get; protected set; }

    public bool isDead = false;

    public event Action<Character> OnDeath;

    public List<ICharacterAction> Actions { get; private set; }

    public void TakeDamage(int dmg)
    {
        if (CurrentHP > 0)
        {
            CurrentHP -= dmg;
            Console.WriteLine($"{Name} is now at {CurrentHP}/{MaxHP} HP.");
        }

        if (CurrentHP <= 0)
        {
            CurrentHP = 0;
            Console.WriteLine("PIPPPPO");
            Die();
        }
    }
    public Character(string name)
    {
        Name = name;
        Actions = new List<ICharacterAction>();
    }

    public void PlayAction(int actionNumber, TheFinalBattleGame theFinalBattle)
    {

        switch (Actions[actionNumber])
        {
            case ICharacterAttackAction attack:
                Party enemyParty = theFinalBattle.partyToPlay == theFinalBattle.Heroes ? theFinalBattle.Monsters : theFinalBattle.Heroes;
                attack.Run(this, enemyParty.Members[0]);
                break;
            case ICharacterAction action:
                action.Run(this);
                break;
        }


    }

    public void Die()
    {
        isDead = true;
        Console.WriteLine($"{Name} has been defeated!");
        OnDeath?.Invoke(this);
    }
}

